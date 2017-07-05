using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public string TipoClaseTres
        {
            get 
            {
                return "ClaseTres " + "Hereda de: " + base.TipoClaseDos; 
            }
        }

        public ClaseTres(string nombre, string padre, string propio)
            :base(nombre, padre)
        { 
            this._atributoClaseTres = propio; 
        }

        public string MostrarClaseTres()
        {
            return base.MostrarClaseDos() + " " + this._atributoClaseTres;
        }



        #region Con Polimorfismo
        //public override string Tipo
        //{
        //    get { return "ClaseTres " + "Hereda de: " + base.Tipo; }
        //}

        //public override string Mostrar()
        //{
        //    return base.Mostrar() + " " + this._atributoClaseTres;
        //}
        #endregion

    }
}
