using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_MVC.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        public virtual string Nombre {  get; set; }


        public override string ToString ()
        {
            return $"{Nombre}, {Id}";
        }

        public ObjetoEscuelaBase () {
            
        }
    }
}