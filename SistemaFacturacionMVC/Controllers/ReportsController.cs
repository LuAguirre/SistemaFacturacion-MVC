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
            if (idProduct != 0 && initDate == null && finalDate == null)
            {
                var listado = await _context.spProducts.FromSqlRaw("VentasxProductoxID @idProduct", new SqlParameter("@idProduct", idProduct)).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = "Productos" });

                ViewData["products"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = idProduct;
                return View(listado);
            }

            if ((idProduct != 0 && idProduct != null) && initDate != null && finalDate != null)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@idProduct", idProduct),
                       new SqlParameter("@fechaInicio", initDate),
                       new SqlParameter("@fechaFinal", finalDate)
                    };

                var listado = await _context.spProducts.FromSqlRaw("VentasxProducto @fechaInicio, @fechaFinal, @idProduct", parameters.ToArray()).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " Productos " });

                ViewData["products"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = idProduct;
                return View(listado);
            }

            if (idProduct == null && initDate != null && finalDate != null)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@fechaInicio", initDate),
                       new SqlParameter("@fechaFinal", finalDate)
                    };

                var listado = await _context.spProducts.FromSqlRaw("VentasxProductoxfechas @fechaInicio, @fechaFinal", parameters.ToArray()).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = "Productos" });

                ViewData["products"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = idProduct;
                return View(listado);
            }

            //  return NotFound();
            Console.WriteLine("not found");
            return View();
        }
    }
}
