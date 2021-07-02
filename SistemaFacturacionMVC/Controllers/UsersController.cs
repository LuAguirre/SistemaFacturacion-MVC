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
    }
}
