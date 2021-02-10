using System;
using System.Collections.Generic;

namespace MyCoreApp.Models
{
    public partial class UserInvoices
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? Price { get; set; }
        public DateTime? Peydate { get; set; }
        public DateTime? Expire { get; set; }
        public string Packet { get; set; }
        public string Tdurum { get; set; }
        public string Taciklama { get; set; }
        public string Tyapan { get; set; }
        public string Kaciklama { get; set; }
        public string Kmesaj { get; set; }
        public string Taksit { get; set; }
        public int? Tekrar { get; set; }
        public DateTime? Otarihi { get; set; }
        public string Sms { get; set; }
        public string Mcoid { get; set; }
    }
}
