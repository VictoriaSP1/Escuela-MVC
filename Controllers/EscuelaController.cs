using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Escuela_MVC.Models;

namespace Escuela_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        
        public IActionResult Index(string id)
        {
            
            ViewBag.CosaDinamica = "La Monja";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        private EscuelaContext _context;
        public EscuelaController(EscuelaContext context)
        {
           _context = context; 
        }
    }
}