using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public abstract class Local
    {

        #region ---------------ATRIBBUTOS--------------
        protected string _direccion;
        protected int _anchoDeFrente;
        #endregion

        #region ---------------PROPIEDADES-------------
        public abstract int AnchoDeFrente{get; set;}
        #endregion

        #region --------------CONSTRUCTORES------------
        public Local(string direccion, int anchoFrente)
        {
            try
            {
                this._direccion = direccion;
                this._anchoDeFrente = anchoFrente;
            }
            catch(AnchoFrenteInvalidoException e)
            {
                throw e;
            }
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("DIRECCION: " + this._direccion);
            cadena.AppendLine("ANCHO DEL FRENTE: " + this._anchoDeFrente + "mts");

            return cadena.ToString();
        }
        #endregion

    }
}
