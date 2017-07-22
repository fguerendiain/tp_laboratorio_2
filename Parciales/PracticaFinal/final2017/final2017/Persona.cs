using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Entidades.Inicio
{
    [XmlInclude(typeof(Alumno))]
    class Persona : Humano
    {
        public string apellido;
        public sbyte edad;

        public Persona(string nombreParam, Eraza razaParam, string apellidoParam, sbyte edadParam) : base(nombreParam, razaParam) {
            this.apellido = apellidoParam;
            this.edad = edadParam;
        }

    }
}
