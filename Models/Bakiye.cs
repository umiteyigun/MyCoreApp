using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Bakiye
    {
        public int Bakiyeid { get; set; }
        public string Username { get; set; }
        public string Gelir { get; set; }
        public string Gider { get; set; }
        public string Tarih { get; set; }
        public string Ekleyen { get; set; }
        public string Aciklama { get; set; }
        public string Baglanti { get; set; }
        public string Baglantitip { get; set; }
    }
}
