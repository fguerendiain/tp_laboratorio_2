using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializacionXml2
{
    //Con este atributo indico que la clase 
    //se puede serializar a XML
    [Serializable]
    public class Dato
    {
        public string nombre;
        public int edad;

        //El constructor por defecto es requerido 
        //para poder serializar a XML
        public Dato()
        {

        }

        public Dato(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append("Nombre: ");
            cadena.AppendLine(this.nombre);
            cadena.Append("Edad: ");
            cadena.AppendLine(this.edad.ToString());

            return cadena.ToString();
       }
    }
}
