using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class spProducts
    {
      
        public int idProduct { get; set; }

        public string name { get; set; }

        public decimal Total_Vendido { get; set; }

        [DataType(DataType.Date)]
        public DateTime dateInvoice { get; set; }
    }
}
