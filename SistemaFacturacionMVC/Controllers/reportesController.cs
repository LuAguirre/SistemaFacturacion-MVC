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
    public class reportesController : Controller
    {
        private readonly ApplicationDBContext _context;

        public reportesController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ReporteVentasProductoAsync(int? idProducto, string fechaInicio, string fechaFinal)
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

        //public async Task<IActionResult> ReporteVentasClienteAsync(int? idCliente, string fechaInicio, string fechaFinal)
        //{
        //    if (idCliente == 0 && fechaInicio == null && fechaFinal == null)
        //    {
        //        var listado = await _context.P_VENTAS_CLIENTE.FromSqlRaw("P_VENTAS_CLIENTE").ToListAsync();

        //        var listItems = _context.Clientes.Select(p => new SelectListItem { Value = Convert.ToString(p.codigo_cliente), Text = p.nombres + " " + p.apellidos }).ToList();
        //        listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

        //        ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
        //        TempData["idCliente"] = idCliente;

        //        return View(listado);
        //    }

        //    if (idCliente != 0 && fechaInicio == null && fechaFinal == null)
        //    {
        //        var listado = await _context.P_VENTAS_CLIENTE.FromSqlRaw("P_VENTAS_CLIENTEP @id", new SqlParameter("@id", idCliente)).ToListAsync();

        //        var listItems = _context.Clientes.Select(p => new SelectListItem { Value = Convert.ToString(p.codigo_cliente), Text = p.nombres + " " + p.apellidos }).ToList();
        //        listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

        //        ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
        //        TempData["idCliente"] = idCliente;

        //        return View(listado);
        //    }

        //    if ((idCliente != 0 && idCliente != null) && fechaInicio != null && fechaFinal != null)
        //    {
        //        // "2021/06/30"
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //            {
        //               new SqlParameter("@id", idCliente),
        //               new SqlParameter("@FechaInicio", fechaInicio),
        //               new SqlParameter("@FechaFinal", fechaFinal)
        //            };

        //        var listado = await _context.P_VENTAS_CLIENTE.FromSqlRaw("P_VENTAS_CLIENTEP_FILTRADO_CODIGOP_FECHAS @id, @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

        //        var listItems = _context.Clientes.Select(p => new SelectListItem { Value = Convert.ToString(p.codigo_cliente), Text = p.nombres + " " + p.apellidos }).ToList();
        //        listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

        //        ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
        //        TempData["idCliente"] = idCliente;

        //        return View(listado);
        //    }

        //    if (idCliente == null && fechaInicio != null && fechaFinal != null)
        //    {
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //            {
        //               new SqlParameter("@FechaInicio", fechaInicio),
        //               new SqlParameter("@FechaFinal", fechaFinal)
        //            };

        //        var listado = await _context.P_VENTAS_CLIENTE.FromSqlRaw("P_VENTAS_CLIENTEP_FILTRADO_CODIGO_SOLO_FECHAS @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

        //        var listItems = _context.Clientes.Select(p => new SelectListItem { Value = Convert.ToString(p.codigo_cliente), Text = p.nombres + " " + p.apellidos }).ToList();
        //        listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

        //        ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
        //        TempData["idCliente"] = 0;

        //        return View(listado);
        //    }

        //    return NotFound();

        //}


        //public async Task<IActionResult> ReporteFacturasAsync(int? todos, string fechaInicio, string fechaFinal)
        //{
        //    if (todos == 0 && fechaInicio == null && fechaFinal == null)
        //    {
        //        var listado = await _context.P_REPORTE_FACTURAS.FromSqlRaw("P_REPORTE_FACTURAS").ToListAsync();

        //        return View(listado);
        //    }

        //    if (todos == null && fechaInicio != null && fechaFinal != null)
        //    {
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //            {
        //               new SqlParameter("@FechaInicio", fechaInicio),
        //               new SqlParameter("@FechaFinal", fechaFinal)
        //            };

        //        var listado = await _context.P_REPORTE_FACTURAS.FromSqlRaw("P_REPORTE_FACTURAS_FECHAS @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

        //        return View(listado);
        //    }


        //    return NotFound();

        //}


    }
}
