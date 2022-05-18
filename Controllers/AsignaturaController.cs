using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Escuela_MVC.Models;

namespace Escuela_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault() );
        }

        public IActionResult MultiAsignatura()
        {            
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Time = DateTime.Now;
            return View("MultiAsignatura", _context.Asignaturas);
        }
    }
}