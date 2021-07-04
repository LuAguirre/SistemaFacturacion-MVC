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
    public class invoicesController : Controller
    {
        private readonly ApplicationDBContext _context;
        public invoicesController(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var aplicationDbContext = _context.invoice.Include(p => p.Client);
            return View(await aplicationDbContext.ToListAsync());
        }

        public IActionResult Create()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.client)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} {item.lastname}", Value = $"{item.id}" });
            }

            ViewData["idClient"] = new SelectList(listItems, "Value", "Text");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,dateInvoice,total,status,idClient")] invoice factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.client)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} {item.lastname}", Value = $"{item.id}" });
            }

            ViewData["idClient"] = new SelectList(listItems, "Value", "Text");
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.invoice.FindAsync(id);

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.client)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} {item.lastname}", Value = $"{item.id}" });
            }

            ViewData["idClient"] = new SelectList(listItems, "Value", "Text");

            return View(factura);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(invoice factura)
        {
            if (ModelState.IsValid)
            {
                _context.Update(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.client)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.name} {item.lastname}", Value = $"{item.id}" });
            }

            ViewData["idClient"] = new SelectList(listItems, "Value", "Text");

            return View();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.invoice.FindAsync(id);
            var cliente = await _context.client.FindAsync(factura.idClient);

            ViewBag.Cliente = cliente.name;
            return View(factura);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var persona = _context.invoice.Find(id);
                _context.invoice.Remove(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }

    }
}
