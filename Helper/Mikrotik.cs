
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
//using System.Web.UI.WebControls.WebParts;

namespace MyCoreApp.Helper
{
    public class MikrotikAPI
    {
        string _IPAddress;
        int _APIPort;
        bool _UseSSL;
        Stream _Stream;
        SslStream _SslStream;
        TcpClient _TcpClient;

        public MikrotikAPI(string IPAddress,bool UseSSL = false, int APIPort = 8728)
        {
            _IPAddress = IPAddress;
            _APIPort = APIPort;            
            _UseSSL = UseSSL;
        }

        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void Connect()
        {
            if (_UseSSL && _APIPort == 8728) _APIPort = 8729;

            _TcpClient = new TcpClient();
            _TcpClient.Connect(_IPAddress, _APIPort);

            if (_UseSSL)
            {
                _SslStream = new SslStream(_TcpClient.GetStream(), false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
                _SslStream.AuthenticateAsClient(_IPAddress);
            }
            else
                _Stream = (Stream)_TcpClient.GetStream();
        }
        public void Disconnect()
        {
            if (_UseSSL)
                _Stream.Close();
            else
                _SslStream.Close();

            _TcpClient.Close();
        }

        public bool LoginDeprecated(string Username, string Password)
        {
            Send("/login", true);
            string hash = Receive()[0].Split(new string[] { "ret=" }, StringSplitOptions.None)[1];
            Send("/login");
            Send("=name=" + Username);
            Send("=response=00" + EncodePassword(Password, hash), true);
            List<string> ReceiveResult = Receive();
            if (ReceiveResult[0] == "!done")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login(string Username, string Password, out string OutMessageDesc)
        {
            OutMessageDesc = "";

            Send("/login");
            Send("=name=" + Username);
            Send("=password=" + Password, true);
            List<string> ReceiveResult = Receive();
            if (ReceiveResult[0] == "!done")
            {
                return true;
            }
            else
            {
                OutMessageDesc = ReceiveResult[1];
                return false;
            }
        }

        public void Send(string DataToSend, bool EndofPacket = false)
        {
            if (_UseSSL)
                DoSendSSL(DataToSend, EndofPacket);
            else
                DoSend(DataToSend, EndofPacket);
        }

        private void DoSend(string DataToSend, bool EndofPacket = false)
        {
            byte[] DataToSendasByte = Encoding.ASCII.GetBytes(DataToSend.ToCharArray());
            byte[] SendSize = EncodeLength(DataToSendasByte.Length);
            _Stream.Write(SendSize, 0, SendSize.Length);
            _Stream.Write(DataToSendasByte, 0, DataToSendasByte.Length);
            if (EndofPacket) _Stream.WriteByte(0);
        }

        private void DoSendSSL(string DataToSend, bool EndofPacket = false)
        {
            byte[] DataToSendasByte = Encoding.ASCII.GetBytes(DataToSend.ToCharArray());
            byte[] SendSize = EncodeLength(DataToSendasByte.Length);
            _SslStream.Write(SendSize, 0, SendSize.Length);
            _SslStream.Write(DataToSendasByte, 0, DataToSendasByte.Length);
            if (EndofPacket) _SslStream.WriteByte(0);
        }

        public ArrayList ReceiveList()
        {
            List<string> ReceivedDataList;

            if (_UseSSL)
                ReceivedDataList = DoReceiveSSL();
            else
                ReceivedDataList = DoReceive();

            ArrayList DataList = new ArrayList();
            List<string> ReceivedData = new List<string>();
            foreach (string DataLine in ReceivedDataList)
            {
                if (DataLine == "!re" || DataLine == "!done" || DataLine == "!trap")
                {
                    DataList.Add(ReceivedData);
                    ReceivedData = new List<string>();
                }
                else
                    ReceivedData.Add(DataLine);
            }
            if (DataList.Count > 1) DataList.RemoveAt(0);

            return DataList;
        }


        public List<string> Receive()
        {
            if (_UseSSL)
                return DoReceiveSSL();
            else
                return DoReceive();
        }

        private List<string> DoReceive()
        {
            List<string> OutputList = new List<string>();
            long TempReceiveSize;
            string TempString = "";
            long ReceiveSize = 0;
            while (true)
            {
                TempReceiveSize = (byte)_Stream.ReadByte();
                if (TempReceiveSize > 0)
                {
                    if ((TempReceiveSize & 0x80) == 0)
                    {
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xC0) == 0x80)
                    {
                        TempReceiveSize &= ~0xC0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xE0) == 0xC0)
                    {
                        TempReceiveSize &= ~0xE0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xF0) == 0xE0)
                    {
                        TempReceiveSize &= ~0xF0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xF8) == 0xF0)
                    {
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_Stream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                }
                else
                    ReceiveSize = TempReceiveSize;

                for (int i = 0; i < ReceiveSize; i++)
                {
                    Char TempChar = (Char)_Stream.ReadByte();
                    TempString += TempChar;
                }

                if (ReceiveSize > 0)
                {
                    OutputList.Add(TempString);
                    if (TempString == "!done") break;
                    TempString = "";
                }
            }
            return OutputList;
        }

        private List<string> DoReceiveSSL()
        {
            List<string> OutputList = new List<string>();
            long TempReceiveSize;
            string TempString = "";
            long ReceiveSize = 0;
            while (true)
            {
                TempReceiveSize = (byte)_SslStream.ReadByte();
                if (TempReceiveSize > 0)
                {
                    if ((TempReceiveSize & 0x80) == 0)
                    {
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xC0) == 0x80)
                    {
                        TempReceiveSize &= ~0xC0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xE0) == 0xC0)
                    {
                        TempReceiveSize &= ~0xE0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xF0) == 0xE0)
                    {
                        TempReceiveSize &= ~0xF0;
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                    else if ((TempReceiveSize & 0xF8) == 0xF0)
                    {
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        TempReceiveSize <<= 8;
                        TempReceiveSize += (byte)_SslStream.ReadByte();
                        ReceiveSize = TempReceiveSize;
                    }
                }
                else
                    ReceiveSize = TempReceiveSize;

                for (int i = 0; i < ReceiveSize; i++)
                {
                    Char TempChar = (Char)_SslStream.ReadByte();
                    TempString += TempChar;
                }

                if (ReceiveSize > 0)
                {
                    OutputList.Add(TempString);
                    if (TempString == "!done") break;
                    TempString = "";
                }
            }
            return OutputList;
        }

        private byte[] EncodeLength(int delka)
        {
            if (delka < 0x80)
            {
                byte[] tmp = BitConverter.GetBytes(delka);
                return new byte[1] { tmp[0] };
            }
            if (delka < 0x4000)
            {
                byte[] tmp = BitConverter.GetBytes(delka | 0x8000);
                return new byte[2] { tmp[1], tmp[0] };
            }
            if (delka < 0x200000)
            {
                byte[] tmp = BitConverter.GetBytes(delka | 0xC00000);
                return new byte[3] { tmp[2], tmp[1], tmp[0] };
            }
            if (delka < 0x10000000)
            {
                byte[] tmp = BitConverter.GetBytes(delka | 0xE0000000);
                return new byte[4] { tmp[3], tmp[2], tmp[1], tmp[0] };
            }
            else
            {
                byte[] tmp = BitConverter.GetBytes(delka);
                return new byte[5] { 0xF0, tmp[3], tmp[2], tmp[1], tmp[0] };
            }
        }

        private string EncodePassword(string Password, string hash)
        {
            byte[] hash_byte = new byte[hash.Length / 2];
            for (int i = 0; i <= hash.Length - 2; i += 2)
            {
                hash_byte[i / 2] = Byte.Parse(hash.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
            }
            byte[] heslo = new byte[1 + Password.Length + hash_byte.Length];
            heslo[0] = 0;
            Encoding.ASCII.GetBytes(Password.ToCharArray()).CopyTo(heslo, 1);
            hash_byte.CopyTo(heslo, 1 + Password.Length);

            Byte[] hotovo;
            System.Security.Cryptography.MD5 md5;

            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            hotovo = md5.ComputeHash(heslo);

            //Convert encoded bytes back to a 'readable' string
            string navrat = "";
            foreach (byte h in hotovo)
            {
                navrat += h.ToString("x2");
            }
            return navrat;
        }

    }
}