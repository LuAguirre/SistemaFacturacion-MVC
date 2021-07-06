using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class reporte1
    {
        [Key]
        public int idProduct { get; set; }
        public string name { get; set; }
        public decimal Total_Vendido { get; set; }
        public DateTime dateInvoice { get; set; }
    }
}
