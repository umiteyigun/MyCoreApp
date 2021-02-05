using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Sayi
    {
        public int Id { get; set; }
        public int? NatSayi { get; set; }
        public int? KutukSayi { get; set; }
        public string Tarih { get; set; }
    }
}
