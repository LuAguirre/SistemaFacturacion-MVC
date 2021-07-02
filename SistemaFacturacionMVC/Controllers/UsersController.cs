using Microsoft.AspNetCore.Mvc;
using SistemaFacturacionMVC.Data;
using SistemaFacturacionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public UsersController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<userT> usersList = _context.user;
            return View(usersList);
        }


        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(userT user)
        {
            if (ModelState.IsValid)
            {
                _context.user.Add(user);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo usuario ha sido creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound("No hay un usuario para editar"); 
            }

            var user = _context.user.Find(id);

            if (user == null)
            {
                return NotFound("No hay un usuario para editar");
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(userT user)
        {
            if (ModelState.IsValid)
            {
                _context.user.Update(user);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo usuario ha sido actualizado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound("No hay un usuario para editar");
            }

            var user = _context.user.Find(id);

            if (user == null)
            {
                return NotFound("No hay un usuario para editar");
            }

            return View(user);
        }
        [HttpPost]
        public IActionResult DeleteUser(int? id)
        {
           var user = _context.user.Find(id);

            if(user == null)
            {
                return NotFound();
            }
                _context.user.Remove(user);
                _context.SaveChanges();

                TempData["menssage"] = "El nuevo usuario ha sido eliminado correctamente";
                return RedirectToAction("Index");
        }
    }
}
