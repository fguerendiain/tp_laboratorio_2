using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }

        public string Nombre
        {
            get {return this._nombre;}
        }
        
        public string Apellido
        {
            get {return this._apellido;}
        }

        public int Edad
        {
            get { return this._edad;}
        }

        public string Sexo
        {
            get { return this._sexo.ToString(); }
        }

        public string MostrarEncabezado()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append("NOMBRE: " + this.Nombre + " - ");
            cadena.Append("APELLIDO: " + this.Apellido + " - ");
            cadena.Append("EDAD: " + this.Edad + " - ");
            cadena.AppendLine("SEXO: " + this.Sexo);

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarEncabezado();
        }

    }
        
}
