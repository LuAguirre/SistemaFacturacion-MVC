using Microsoft.AspNetCore.Mvc;
using SistemaFacturacionMVC.Data;
using SistemaFacturacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    public class clientsController : Controller
    {
        private readonly ApplicationDBContext _context;
        public clientsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<client> clientsList = _context.client;

            return View(clientsList);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(client cli)
        {
            if (ModelState.IsValid)
            {
                _context.client.Add(cli);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo cliente ha sido creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("No hay un cliente para editar");
            }

            var user = _context.client.Find(id);

            if (user == null)
            {
                return NotFound("No hay un cliente para editar");
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(client cli)
        {
            if (ModelState.IsValid)
            {
                _context.client.Update(cli);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo cliente ha sido actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("No hay un cliente para eliminar");
            }

            var user = _context.client.Find(id);

            if (user == null)
            {
                return NotFound("No hay un cliente para eliminar");
            }

            return View(user);
        }
        [HttpPost]
        public IActionResult DeleteClient(int? id)
        {
            try
            {
                var cli = _context.client.Find(id);

                if (cli == null)
                {
                    return NotFound();
                }
                _context.client.Remove(cli);
                _context.SaveChanges();

                TempData["menssage"] = "El cliente ha sido eliminado correctamente";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
               TempData["menssageClient"] = "El cliente no puede ser eliminado debido a la relación con una factura";
                return RedirectToAction("Index");
            }
        }

        
    }
}

