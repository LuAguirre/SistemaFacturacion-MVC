using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaFacturacionMVC.Data;
using SistemaFacturacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    [Authorize]
    public class productsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public productsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<product> usersList = _context.product;
            return View(usersList);
        }




        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(product pr)
        {
            if (ModelState.IsValid)
            {
                _context.product.Add(pr);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo producto ha sido creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("No hay un producto para editar");
            }

            var user = _context.product.Find(id);

            if (user == null)
            {
                return NotFound("No hay un producto para editar");
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(product pr)
        {
            if (ModelState.IsValid)
            {
                _context.product.Update(pr);
                _context.SaveChanges();

                TempData["menssage"] = "El producto ha sido actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            var product = _context.product.Find(id);
            if (id.HasValue == false)
            {
                return RedirectToAction("HttpError404");
            }
            else
            {
                return View(product);
            }
        }

        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var product = _context.product.Find(id);
                _context.product.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                TempData["menssageDelete"] = "El producto no puede ser eliminado debido a que hay relación con detalles de factura ";
                return RedirectToAction("Index");
            }


        }

        public ActionResult HttpError404(Exception erro)
        {
            TempData["Error"] = erro.Message;
            return View();
        }
    }
}
