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

    }
}
