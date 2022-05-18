using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Escuela_MVC.Models;

namespace Escuela_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context;

        public AlumnoController(EscuelaContext context)
            {
                    _context = context;
            }
        public IActionResult Index()
        {
            return View(_context.Alumnos.FirstOrDefault());
        }

        public IActionResult MultiAlumno()
        {

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.Alumnos);
        }

        

    }
}