using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class product
    {
        [Key]
        public int idProduct { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El campo es obligatorio")]
        public string name { get; set; }
        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string description { get; set; }
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo es requerido")]
        public decimal price { get; set; }
        [Display(Name = "Costo")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public decimal cost { get; set; }
        [Display(Name = "Existencia")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int existence { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string status { get; set; }
    }
}
