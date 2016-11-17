using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Main
{
    class PersonaExternaHeredada : PersonaExterna
    {

        public PersonaExternaHeredada(string nombre, string apellido, int edad, ESexo sexo):base(nombre,apellido,edad,sexo)
        {
        }

        public string MostrarEncabezado()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append("NOMBRE: " + this._nombre + " - ");
            cadena.Append("APELLIDO: " + this._apellido + " - ");
            cadena.Append("EDAD: " + this._edad + " - ");
            cadena.AppendLine("SEXO: " + this._sexo);

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarEncabezado();
        }


    }
}
