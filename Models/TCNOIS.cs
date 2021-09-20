using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreApp.Models
{
    public class TCNOIS
    {
        [Key]
        public int TCNOIDD { get; set; }
        public string YATANHASTATCS { get; set; }
    }
}
