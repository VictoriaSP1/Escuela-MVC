using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Escuela_MVC.Models
{
    public class EscuelaContext: DbContext
    {
        public DbSet <Escuela> Escuelas { get; set; }
        public DbSet <Asignatura> Asignaturas { get; set; }
        public DbSet <Alumno> Alumnos { get; set; }
        public DbSet <Curso> Cursos { get; set; }
        public DbSet <Evaluacion> Evaluaciones { get; set; }
        public EscuelaContext (DbContextOptions<Escuela> options): base (options) 
        {
            
        }
    }
}