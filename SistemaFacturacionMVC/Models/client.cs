using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class client
    {
        public int id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string name { get; set; }
        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string lastname { get; set; }
        [Display(Name ="NIT")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string nit { get; set; }
        [Display(Name ="Teléfono")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string phone { get; set; }
        [Display(Name ="Status")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string status { get; set; }

    }
}
