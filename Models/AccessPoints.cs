using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class AccessPoints
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nasname { get; set; }
        public string Ip { get; set; }
        public string Username { get; set; }
        public string Secret { get; set; }
        public int? Port { get; set; }
        public string Description { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
    }
}
