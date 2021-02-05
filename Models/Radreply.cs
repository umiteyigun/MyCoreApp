using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Radreply
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Attribute { get; set; }
        public string Op { get; set; }
        public string Value { get; set; }
    }
}
