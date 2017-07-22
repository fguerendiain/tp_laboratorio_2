using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades.Inicio
{
    [XmlInclude(typeof(Persona))]
    public class Humano
    {
        public string nombre;
        public Eraza raza;

        public Humano(string nombreParam, Eraza razaParam) {
            this.nombre = nombreParam;
            this.raza = razaParam;
        }
        
   }
}

enum Eraza { Aria, Mestiza, Negra, Cabeza };
