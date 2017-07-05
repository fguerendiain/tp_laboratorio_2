using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializacionBinaria
{
    //Con este atributo indico que la clase 
    //se puede serializar a Binario
    //La clase puede o no ser pública
    [Serializable]
    class Dato
    {
        public string nombre;
        public int edad;
        protected int _dni;
        private string _apodo;

        //El constructor por defecto es requerido 
        //para poder serializar en binario
        public Dato()
        {

        }

        public Dato(string nombre, int edad, int dni, string apodo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this._dni = dni;
            this._apodo = apodo;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append("Nombre: ");
            cadena.AppendLine(this.nombre);
            cadena.Append("Edad: ");
            cadena.AppendLine(this.edad.ToString());
            cadena.Append("Dni: ");
            cadena.AppendLine(this._dni.ToString());
            cadena.Append("Apodo: ");
            cadena.AppendLine(this._apodo);

            return cadena.ToString();
        }
    }
}
