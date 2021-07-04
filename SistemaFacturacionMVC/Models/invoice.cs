using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class invoice
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Cliente")]
        public int? idClient { get; set; }
        [ForeignKey("idClient")]
        public virtual client Client { get; set; }
        [Display(Name ="Total Factura")]
        public decimal total { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public DateTime dateInvoice { get; set; }

        [Display(Name ="Status Factura")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        public string status { get; set; }
    }
}
