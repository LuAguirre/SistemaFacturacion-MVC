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

        async public  Task<IActionResult> product(int? idProducto, string fechaInicio, string fechaFinal)
        {
            if (idProducto == 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.spProducts.FromSqlRaw("ventaProductos").ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");
                TempData["idProducto"] = idProducto;

                return View(listado);
            }

            if (idProducto != 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.spProducts.FromSqlRaw("VentasxProductoxID @idProduct", new SqlParameter("@idProduct", idProducto)).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = idProducto;
                return View(listado);
            }

            if ((idProducto != 0 && idProducto != null) && fechaInicio != null && fechaFinal != null)
            {
                // "2021-06-30"
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@idProduct", idProducto),
                       new SqlParameter("@fechaInicio", fechaInicio),
                       new SqlParameter("@fechaFinal", fechaFinal)
                    };

                var listado = await _context.spProducts.FromSqlRaw("VentasxProducto @fechaInicio, @fechaFinal, @idProduct", parameters.ToArray()).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = idProducto;
                return View(listado);
            }

            if (idProducto == null && fechaInicio != null && fechaFinal != null)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@fechaInicio", fechaInicio),
                       new SqlParameter("@fechaFinal", fechaFinal)
                    };

                var listado = await _context.spProducts.FromSqlRaw("VentasxProductoxfechas @fechaInicio, @fechaFinal", parameters.ToArray()).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = 0;
                return View(listado);
            }

            return NotFound();
        }

    }
}
