using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class invoiceProduct
    {
        //[Key, Column(Order = 0)]
        [Display(Name = "Factura")]
        public int? idInvoice { get; set; }
        [ForeignKey("idInvoice")]
        public virtual invoice Invoice { get; set; }

        
        //[Key, Column(Order = 1)]
        [Display(Name = "Producto")]
        public int? idProduct { get; set; }
        [ForeignKey("idProduct")]
        public virtual product Product { get; set; }
    }
}
