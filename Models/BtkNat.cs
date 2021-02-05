using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class BtkNat
    {
        public int Id { get; set; }
        public string KullaniciAd { get; set; }
        public string OzelIp { get; set; }
        public string OIpPBas { get; set; }
        public string OIpPBit { get; set; }
        public string GercekIp { get; set; }
        public string GIpPBas { get; set; }
        public string GIpPBit { get; set; }
        public string OBasTarih { get; set; }
        public string OBitTarih { get; set; }
        public string UpByte { get; set; }
        public string DownByte { get; set; }
        public string BKM { get; set; }
        public string ODurum { get; set; }
        public string BPvc { get; set; }
        public string ServisNo { get; set; }
        public string OKod { get; set; }
        public sbyte? Imza { get; set; }
    }
}
