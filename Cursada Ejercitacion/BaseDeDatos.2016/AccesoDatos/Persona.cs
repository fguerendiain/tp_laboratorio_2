using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Persona
    {
        #region Atributos

        private int _id;
        private string _nombre;
        private string _apellido;
        private int _edad;

        #endregion

        #region Propiedades

        public int ID
        {
            get
            {
                return _id;
            }
         }
        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public String Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }
        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Inicializa una persona
        /// </summary>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        public Persona(string apellido, string nombre, int edad)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._edad = edad;
        }
        /// <summary>
        /// Inicializa una persona
        /// </summary>
        /// <param name="ID">ID de la persona en la BD</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="edad">Edad de la persona</param>
        public Persona(int ID, string apellido, string nombre, int edad)
            :this(apellido,nombre,edad)
        {
            this._id = ID;
        }
        #endregion

    }
}
