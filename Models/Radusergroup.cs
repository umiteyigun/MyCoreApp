using System;
using System.Collections.Generic;

namespace MyCoreApp.Models
{
    public partial class Radusergroup
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Groupname { get; set; }
        public int Priority { get; set; }
    }
}
