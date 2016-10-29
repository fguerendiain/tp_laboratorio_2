using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    abstract class Persona
    {
        #region ATRIBBUTOS---------------------------
        protected string _apellido;
        protected int _dni;
        protected ENacionalidad _nacionalidad;
        protected string _nombre;
        #endregion

        #region PROPIEDADES--------------------------
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

        #region CONSTRUCTORES------------------------
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
        
        
        #region METODOS------------------------------
        protected int ValidarDni(ENacionalidad nacionalidad, int dato);
        protected int ValidarDni(ENacionalidad nacionalidad, string dato);
        protected string ValidarNombreApellido(string dato);
        #endregion
        
        
        #region SOBRECARGA DE METODOS----------------
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
        
        #region ENUMERADOS

        public enum ENacionalidad { }

        #endregion


    }
}
