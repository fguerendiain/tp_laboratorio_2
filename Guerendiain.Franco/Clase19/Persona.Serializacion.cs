using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase19
{
    [XmlInclude(typeof(PersonaH))]
    public class Persona
    {
        public string _nombre;
        public string _apellido;
        public long _dni;



        public Persona()
        { 
            
        }

        public Persona(string nombre, string apellido, long dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }

        public static void MostrarPersona(Persona p)
        {
            Console.WriteLine(p.ToString());
            Console.WriteLine();
        }
		
        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: "+ this._nombre);
            sb.AppendLine("Apellido: "+ this._apellido);
            sb.AppendLine("Dni: "+ this._dni.ToString());
            sb.AppendLine();
			return sb.ToString();
        }

    }
}
