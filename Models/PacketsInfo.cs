using System;
using System.Collections.Generic;

namespace MyCoreApp.Models
{
    public partial class PacketsInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Download { get; set; }
        public string Upload { get; set; }
        public int Price { get; set; }
        public string Traffic { get; set; }
        public string Sat { get; set; }
    }
}
