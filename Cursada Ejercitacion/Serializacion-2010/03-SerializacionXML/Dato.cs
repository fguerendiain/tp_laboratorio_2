using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializacionXml3
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

        #region Métodos para ordenar en la Lista

        /// <summary>
        /// Método estático que compara los nombres
        /// de dos objetos de tipo Dato
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public static int CompararNombre(Dato valor1, Dato valor2)
        {
            return valor1.nombre.CompareTo(valor2.nombre);
        }

        /// <summary>
        /// Método estático que compara las edades
        /// de dos objetos de tipo Dato
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns></returns>
        public static int CompararEdad(Dato valor1, Dato valor2)
        {
            return valor1.edad.CompareTo(valor2.edad);
        }

        #endregion
    }
}
