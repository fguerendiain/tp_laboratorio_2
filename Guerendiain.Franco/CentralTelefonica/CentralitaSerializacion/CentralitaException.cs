using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class CentralitaException : Exception
    {
        #region ATRIBUTOS
        private Exception _excepcionInterna;
        private string _nombreClase;
        private string _nombreMetodo;
        #endregion

        #region PROPIEDADES
        public Exception ExcepcionInterna
        {
            get {return this._excepcionInterna;}
        }

        public string NombreClase
        {
            get { return this._nombreClase;}
        }

        public string NombreMetodo
        {
            get { return this._nombreMetodo;}
        }
        #endregion

        #region CONSTRUCTORES
        public CentralitaException(string mensaje, string clase, string metodo):this(mensaje,clase,metodo,null)
        {

        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerEsception): base (mensaje,innerEsception)
        {
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }
        
        #endregion


    }
}
