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
        string Apellido
        {
            get {return this._apellido;}
            set { this._apellido = value;}
        }
        
        int DNI
        {
            get { return this._dni; }
            set { this._dni = value; }
        }
        
        ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }
        
        string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        
        string StringToDNI
        {
            set{int.TryParse(value, out this._dni);}
        }
        #endregion

        #region --------------CONSTRUCTORES------------
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
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.StringToDNI = dni;
        }

        
        
        #endregion
        
        #region -----------------METODOS---------------
        protected int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato < 89999999)
                {
                    return dato;
                }
                else
                {
                    throw new DniInvalidoException();
                }

            }
            else
            {
                throw new DniInvalidoException("La nacionalidad no se condice con el numero de DNI\n");
            }
        }

        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            this.StringToDNI = dato;
            return ValidarDni(nacionalidad, dato);
        }

        protected string ValidarNombreApellido(string dato)
        {
            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
            {
                return "";
            }
            return dato;
        }


        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("NOMBRE COMPLETO: " + this._apellido + ", " + this._nombre);

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
