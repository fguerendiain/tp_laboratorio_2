﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    abstract class PersonaGimnasio : Persona
    {
        #region ATRIBBUTOS
        protected int _identificador;
        #endregion

        #region CONSTRUCTORES
        public PersonaGimnasio(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        : base(nombre, apellido, dni, nacionalidad)
        {
            this._identificador = id;
        }

        #endregion

        #region METODOS
        public virtual string MostrarDatos();
        public virtual string ParticiparEnClase();

        #endregion

        #region SOBRECARGA DE METODOS
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return true;
        }

        public static bool operator !=(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return !(pg1==pg2);
        }
        #endregion

    }
}
