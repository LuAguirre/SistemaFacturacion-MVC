using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacionMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ReportsController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        async public  Task<IActionResult> product(int? idProduct, string initDate, string finalDate)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.product)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} ", Value = $"{item.idProduct}" });
            }

            ViewData["idProduct"] = new SelectList(listItems, "Value", "Text");

            if (idProduct != 0 && initDate == null && finalDate == null)
            {
                var list = await _context.spProducts.FromSqlRaw("sellProductByID @idProduct", new SqlParameter("@idProduct", idProduct)).ToListAsync();
                return View(list);
               
            }
            else
            {

                TempData["mensaje"] = "No se han encontrado resultados para este reporte";
                return View();
            }
        }
    }
}
