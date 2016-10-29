using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    abstract class PersonaGimnasia : Persona
    {
        #region ATRIBBUTOS
        protected int _identificador;
        #endregion

        #region CONSTRUCTORES
        public PersonaGimnasia(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        : base(nombre, apellido, dni, nacionalidad)
        {
            this._identificador = id;
        }

        #endregion

        #region METODOS
        #endregion

        #region SOBRECARGA DE METODOS
        #endregion

        #region SOBRECARGA DE OPERADORES
        #endregion

    }
}
