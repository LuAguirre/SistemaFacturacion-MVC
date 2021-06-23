using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class user
    { 
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string name { get; set; }
        public string lastame { get; set; }
        public string rol { get; set; }
    }
}
