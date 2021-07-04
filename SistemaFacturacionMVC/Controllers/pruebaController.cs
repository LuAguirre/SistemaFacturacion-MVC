using Microsoft.AspNetCore.Mvc;
using SistemaFacturacionMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacionMVC.Controllers
{
    public class pruebaController : Controller
    {
        private readonly ApplicationDBContext _context;


        public pruebaController(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
