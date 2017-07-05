﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{

    public abstract class PersonaGimnasio : Persona
    {
        #region ---------------ATRIBBUTOS--------------
        protected int _identificador;
        #endregion

        #region --------------CONSTRUCTORES------------
        public PersonaGimnasio()
        { 
        }
                
        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        : base(nombre, apellido, dni, nacionalidad)
        {
            this._identificador = id;
        }

        #endregion

        #region -----------------METODOS---------------

        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.ToString());
            cadena.AppendLine("CARNET NUMERO: " + this._identificador);

            return cadena.ToString();

        }
            
        protected abstract string ParticiparEnClase();

        #endregion

       #region ----------SOBRECARGA DE METODOS--------
        /// <summary>
        /// Valida que el objeto sea del tipo de la clase
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(object.ReferenceEquals(obj, null))
            {
                return false;
            }
            return obj.Equals(obj.GetType());
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        /// <summary>
        /// Dos objetos de la clase son iguales si conicide su tipo y ID o DNI,
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return (pg1.GetType() == pg2.GetType() && ((pg1._identificador == pg2._identificador) || (pg1._dni == pg2._dni)));
        }

        public static bool operator !=(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return !(pg1==pg2);
        }
        #endregion

    }
}
