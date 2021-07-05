using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacionMVC.Data;
using SistemaFacturacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    public class invoiceProductsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public int? noInvoice;
        public invoiceProductsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var applicationDbContext = _context.invoiceProduct.Where(p => p.idInvoice == id).Include(p => p.Product);
            var invoice = _context.invoice.Find(id);
            ViewBag.facturaAnulada = Convert.ToString(invoice.status);
            TempData["idInvoice"] = id;
            noInvoice = id;
            ViewBag.numFactura = id;
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Create(int? id)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.product.Where(p => p.status == "Activo"))
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} | {item.description}", Value = $"{item.idProduct}" });
            }

            TempData["idInvoice"] = Convert.ToString(id);
            ViewData["idProduct"] = new SelectList(listItems, "Value", "Text");

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("idInvoice,idProduct,price,quantity")] invoiceProduct details)
        {
            if (ModelState.IsValid)
            {
                product producto = _context.product.Find(details.idProduct);
                details.price = producto.price;

                if()

                if (details.quantity <= producto.existence)
                {
                    _context.invoiceProduct.Add(details);
                    _context.SaveChanges();

                    producto.existence = producto.existence - details.quantity;
                    _context.product.Update(producto);
                    _context.SaveChanges();

                    invoice inv = _context.invoice.Find(details.idInvoice);
                    inv.total = (details.price * details.quantity) + inv.total;
                    _context.invoice.Update(inv);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "invoiceProducts", new { id = details.idInvoice });

                }
                else
                {
                    ViewBag.Message = String.Format($"Solo contamos con  {producto.existence} unidades de {producto.name}, por favor intenta de nuevo.");
                }
            }

            TempData["idInvoice"] = Convert.ToString(details.idInvoice);
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.product.Where(p => p.status == "Activo"))
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name}", Value = $"{item.idProduct}" });
            }

            ViewData["idProduct"] = new SelectList(listItems, "Value", "Text");
            return View();
        }

    }
}
