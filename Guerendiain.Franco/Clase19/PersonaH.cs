using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
     public class PersonaH : Persona
    {
         public string aliento;

         public PersonaH()
         { 
         }

         public PersonaH(string alien, string nombre, string apellido, long dni)
             : base(nombre, apellido, dni)
         {
             this.aliento = alien;
         }
     
    }
}
