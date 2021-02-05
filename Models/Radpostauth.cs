using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Radpostauth
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Reply { get; set; }
        public DateTimeOffset Authdate { get; set; }
    }
}
