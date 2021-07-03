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
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string name { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string lastame { get; set; }
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string rol { get; set; }
        [Display(Name ="Usuario")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string username { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string password { get; set; }
    }
}
