using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Models
{
    public class estadisticasFactura
    {
        public int Total_facturas { get; set; }
        public decimal monto_facturado { get; set; }
        public int total_Productos { get; set; }
        public DateTime dateInvoice { get; set; }
    }
}
