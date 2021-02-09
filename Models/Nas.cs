using System;
using System.Collections.Generic;

namespace MyCoreApp.Models
{
    public partial class Nas
    {
        public int Id { get; set; }
        public string Nasname { get; set; }
        public string Shortname { get; set; }
        public string Type { get; set; }
        public int? Ports { get; set; }
        public string Secret { get; set; }
        public string Server { get; set; }
        public string Community { get; set; }
        public string Description { get; set; }
    }
}
