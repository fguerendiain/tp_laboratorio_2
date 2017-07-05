using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseUno
    {
        protected string _nombre;

        public string TipoClaseUno
        {
            get { return "ClaseUno"; }
        }

        public ClaseUno(string nombre) { this._nombre = nombre; }

        public string MostrarClaseUno()
        {
            return this._nombre;
        }





        #region Con Polimorfismo
        //public virtual string Tipo
        //{
        //    get { return "ClaseUno"; }
        //}

        //public virtual string Mostrar()
        //{
        //    return this._nombre;
        //}
        #endregion
    }
}
