using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCoreApp.Models
{
    [Table("TCNOIS")]
    public partial class TcnoHasta
    {
        [Key]
        public int TCNOIDD { get; set; }
        public string YATANHASTATCS { get; set; }
    }
}
