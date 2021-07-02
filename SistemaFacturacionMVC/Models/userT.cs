using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class userT
    { 
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [Display(Name = "Apellido")]
        public string lastame { get; set; }
        [Display(Name = "Rol")]
        public string rol { get; set; }
        [Display(Name ="Usuario")]
        public string username { get; set; }
        [Display(Name = "Contraseña")]
        public string password { get; set; }
    }
}
