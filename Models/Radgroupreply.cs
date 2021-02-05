using System;
using System.Collections.Generic;

namespace dotnet.Models
{
    public partial class Radgroupreply
    {
        public uint Id { get; set; }
        public string Groupname { get; set; }
        public string Attribute { get; set; }
        public string Op { get; set; }
        public string Value { get; set; }
    }
}
