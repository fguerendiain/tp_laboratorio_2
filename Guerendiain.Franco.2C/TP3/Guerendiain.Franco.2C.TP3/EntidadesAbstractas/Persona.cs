using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
     public abstract class Persona
    {
        #region --------------ATRIBBUTOS--------------
        protected string _apellido;
        protected int _dni;
        protected ENacionalidad _nacionalidad;
        protected string _nombre;
        #endregion

        #region ---------------PROPIEDADES-------------
        public string Apellido
        {
            get {return this._apellido;}
            set { this._apellido = ValidarNombreApellido(value); }
        }

        public int DNI
        {
            get { return this._dni; }
            set { this._dni = ValidarDni(this._nacionalidad, value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = ValidarNombreApellido(value); }
        }

        public string StringToDNI
        {
            set
            {
                if (!int.TryParse(value = value.Replace(".", ""), out this._dni))
                {
                    throw new Excepciones.DniInvalidoException();
                }

            }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Persona()
        { 
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this._dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        
        
        #endregion
        
        #region -----------------METODOS---------------
        protected int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Extranjero)
            {
                if (dato > 89999999 && dato < 99999999)
                {
                    return dato;
                }
            }

            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato <= 89999999)
                {
                    return dato;
                }
            }
            
            throw new DniInvalidoException("La nacionalidad no se condice con el numero de DNI\n");
        }

        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int aux = int.Parse(dato);
            return ValidarDni(nacionalidad, aux);
        }

        protected string ValidarNombreApellido(string dato)
        {
            Regex ex = new Regex("^[A-Za-z]+$");

            if (!ex.IsMatch(dato))
            {
                return dato;
            }
            return "";
        }


        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("NOMBRE COMPLETO: " + this._apellido + ", " + this._nombre);
            cadena.AppendLine("NACIONALIDAD: " + this._nacionalidad);

            return cadena.ToString();
        }
        #endregion

        #region ----------------ENUMERADOS-------------

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        #endregion


    }
}
