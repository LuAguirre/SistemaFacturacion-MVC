using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class spClient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname {get; set;}
        public decimal total_vendido { get; set; }
    
        public DateTime dateInvoice { get; set; }

    }
}
