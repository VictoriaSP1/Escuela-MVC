using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Escuela_MVC.Models
{
    public class Curso: ObjetoEscuelaBase
    {
        [Required] //Se utiliza para que sea necesario un atributo

        public override string Nombre { set; get; } //Se usó un método virtual que se sobreescribió con override
                                                    //porque solo se necesita que sea requerido el nombre del curso 
                                                    //y no el nombre del resto de clases que heredan de ObjetoEscuelaBase
        public TiposJornada Jornada { get; set; }
        public List <Asignatura> Asignaturas {  get; set;   }
        public List <Alumno> Alumnos {  get; set;   }
        //public string Direccion { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }
}