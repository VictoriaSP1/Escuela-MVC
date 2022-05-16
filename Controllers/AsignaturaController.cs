using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_MVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index ()
        {
            var Asignatura = new Asignatura {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };
          
            return View(Asignatura);
        }
    }
}