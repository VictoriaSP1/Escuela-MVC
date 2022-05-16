using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_MVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index ()
        {
            var escuela = new Escuela ();
            escuela.AnioDeCreacion=2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi School";
            return View(escuela);
        }
    }
}