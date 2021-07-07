using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacionMVC.Data;
using SistemaFacturacionMVC.Models;
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
                //String query = "select p.idProduct, p.name, ip.price, ip.quantity, sum(ip.price * quantity) as Total_Vendido, i.dateInvoice from product as p, invoiceProduct ip, invoice i where p.idProduct = ip.idProduct and ip.idInvoice = i.id group by p.idProduct, p.name, i.dateInvoice, ip.price, ip.quantity";
                //String queryGG = "select * from product";
                List<spProducts> list = _context.spProducts.FromSqlRaw("ventaProductos").ToList();
                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " Productos " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");
                TempData["idProducto"] = idProducto;

                return View(list);
            }

            if (idProducto != 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.spProducts.FromSqlRaw("VentasxProductoxID @idProduct", new SqlParameter("@idProduct", idProducto)).ToListAsync();

                var listItems = _context.product.Select(p => new SelectListItem { Value = Convert.ToString(p.idProduct), Text = p.name }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " Productos " });

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
                listItems.Add(new SelectListItem() { Value = "0", Text = " Productos " });

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
                listItems.Add(new SelectListItem() { Value = "0", Text = " Productos " });

                ViewData["productos"] = new SelectList(listItems, "Value", "Text");

                TempData["idProducto"] = 0;
                return View(listado);
            }

            return NotFound();
        }

        public async Task<IActionResult> invoiceStadistics( string fechaInicio, string fechaFinal)
        {
          
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@fechaInicio", fechaInicio),
                       new SqlParameter("@fechaFinal", fechaFinal)
                    };

                var listado = await _context.estadisticasFacturas.FromSqlRaw("estadisticasFactura @fechaInicio, @fechaFinal", parameters.ToArray()).ToListAsync();

                return View(listado);
            
        }

        public async Task<IActionResult> clientsReport(int? idCliente, string fechaInicio, string fechaFinal)
        {
            if (idCliente == 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.spClient.FromSqlRaw("ventasClientes").ToListAsync();

                var listItems = _context.client.Select(p => new SelectListItem { Value = Convert.ToString(p.id), Text = p.name + " " + p.lastname }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = "Clientes" });

                ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
                TempData["idCliente"] = idCliente;

                return View(listado);
            }

            if (idCliente != 0 && fechaInicio == null && fechaFinal == null)
            {
                var listado = await _context.spClient.FromSqlRaw("ventasClientesID @id", new SqlParameter("@id", idCliente)).ToListAsync();

                var listItems = _context.client.Select(p => new SelectListItem { Value = Convert.ToString(p.id), Text = p.name + " " + p.lastname }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = "Clientes" });

                ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
                TempData["idCliente"] = idCliente;

                return View(listado);
            }

            if ((idCliente != 0 && idCliente != null) && fechaInicio != null && fechaFinal != null)
            {
                // "2021/06/30"
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@id", idCliente),
                       new SqlParameter("@fechaInicio", fechaInicio),
                       new SqlParameter("@fechaFinal", fechaFinal)
                    };

                var listado = await _context.spClient.FromSqlRaw("ventasClientesIDFecha @id, @fechaInicio, @fechaFinal", parameters.ToArray()).ToListAsync();

                var listItems = _context.client.Select(p => new SelectListItem { Value = Convert.ToString(p.id), Text = p.name + " " + p.lastname }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = " -- Todos -- " });

                ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
                TempData["idCliente"] = idCliente;

                return View(listado);
            }

            if (idCliente == null && fechaInicio != null && fechaFinal != null)
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                    {
                       new SqlParameter("@fechaInicio", fechaInicio),
                       new SqlParameter("@fechaFinal", fechaFinal)
                    };

                var listado = await _context.spClient.FromSqlRaw("ventasClientesFecha @fechaInicio, @fechaFinal", parameters.ToArray()).ToListAsync();

                var listItems = _context.client.Select(p => new SelectListItem { Value = Convert.ToString(p.id), Text = p.name + " " + p.lastname }).ToList();
                listItems.Add(new SelectListItem() { Value = "0", Text = "Clientes" });

                ViewData["clientes"] = new SelectList(listItems, "Value", "Text");
                TempData["idCliente"] = 0;

                return View(listado);
            }

            return NotFound();

        }


    }
}
