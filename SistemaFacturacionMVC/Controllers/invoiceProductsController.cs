using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
                listItems.Add(new SelectListItem() { Text = $"{item.name}", Value = $"{item.idProduct}" });
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
                   if (details.quantity <= producto.existence)
                   {
                    _context.invoiceProduct.Add(details);
                    _context.SaveChanges();

                    producto.existence = producto.existence - details.quantity;
                    _context.product.Update(producto);
                    _context.SaveChanges();

                    invoice invo = _context.invoice.Find(details.idInvoice);
                    invo.total = (details.price * details.quantity) + invo.total;
                    _context.invoice.Update(invo);
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

        public async Task<IActionResult> Edit(int? idInvoice, int? idProduct)
        {
            if (idInvoice == null || idProduct == null)
            {
                return NotFound();
            }

            var detalle = await _context.invoiceProduct.FindAsync(idInvoice, idProduct);

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.product)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name}", Value = $"{item.idProduct}" });
            }

            TempData["idInvoice"] = idInvoice;
            TempData["idProduct"] = idProduct;
            ViewData["idProduct"] = new SelectList(listItems, "Value", "Text");

            return View(detalle);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? idInvoice, int? idProduct, int quantity)
        {
            TempData["idInvoice"] = idInvoice;
            invoiceProduct detail = _context.invoiceProduct.Find(idInvoice, idProduct);
            product pr = _context.product.Find(idProduct);
            invoice invo = _context.invoice.Find(idInvoice);

            

            if (ModelState.IsValid)
            {
               
                var currentExistence = detail.quantity + pr.existence;
                if (quantity <= currentExistence)
                {
                    invo.total = invo.total - (detail.quantity * pr.price);
                    invo.total = invo.total + (detail.quantity * pr.price);

                    _context.invoice.Update(invo);
                    _context.SaveChanges();

                    detail.price = pr.price;
                    detail.quantity = quantity;
                    _context.invoiceProduct.Update(detail);
                    _context.SaveChanges();

                    pr.existence = currentExistence - quantity;
                    _context.product.Update(pr);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "invoiceProducts", new { id = idInvoice });
                }
                else
                {
                    ViewBag.Message = String.Format($"Solo hay {currentExistence} unidades en existecia de {pr.name}");
                }
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.product)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name}", Value = $"{item.idProduct}" });
            }

            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }

        public IActionResult Delete(int? idInvoice, int? idProduct)
        {
            if (idInvoice == null || idProduct == null)
            {
                return NotFound();
            }
            TempData["idInvoice"] = Convert.ToString(idInvoice);

            var detalle = _context.invoiceProduct.Find(idInvoice, idProduct);

            return View(detalle);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? numeroFactura, int? codigoProducto)
        {
            TempData["idInvoice"] = Convert.ToString(numeroFactura);
            try
            {
                var producto = _context.product.Find(codigoProducto);
                var factura = _context.invoice.Find(numeroFactura);
                var detalle = _context.invoiceProduct.Find(numeroFactura, codigoProducto);

                factura.total = factura.total - (detalle.quantity * producto.price);
                _context.invoice.Update(factura);
                _context.SaveChanges();

                producto.existence = producto.existence + detalle.quantity;
                _context.product.Update(producto);
                _context.SaveChanges();

                _context.invoiceProduct.Remove(detalle);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "invoiceProducts", new { id = detalle.idInvoice });
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }



    }
}
