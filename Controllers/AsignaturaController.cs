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
            return View(new Asignatura{Nombre="Programación",
                                Id= Guid.NewGuid().ToString()
                            });
        }

        public IActionResult MultiAsignatura()
        {            
            var StudentList = _context.Alumnos.ToList();
            ViewBag.Time = DateTime.Now;
            return View(StudentList);
        }
    }
}