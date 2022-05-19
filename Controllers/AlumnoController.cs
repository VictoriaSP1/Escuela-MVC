using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Escuela_MVC.Models;

namespace Escuela_MVC.Controllers
{
    public class AlumnoController : Controller
    {
        [Route("Alumno/Index")]
        
        public IActionResult Index(string id)
        {
            if(!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from alumn in _context.Alumnos
                                        where alumn.Id == id
                                        select alumn;

                return View(alumno.SingleOrDefault());
            }
            else
            {
               return View("MultiAlumno", _context.Alumnos); 
            }
        }

        public IActionResult MultiAlumno()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View("MultiAlumno", _context.Alumnos);
        }

        //ModelState en caso de que el modelo sea válido
         [HttpPost]
        public IActionResult Create(Curso curso)
        {
            ViewBag.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                ViewBag.MensajeExtra ="Curso Creado";
                //Lleva al index con el nombre del curso recién creado
                return View("Index", curso);
            }
            else
            {
                //Lleva al curso en caso de que no
                return View(curso);
            }
            
        }
        
        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
           _context = context; 
        }
    }
}