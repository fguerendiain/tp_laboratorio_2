using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Local : Llamada
    {

        #region ATRIBUTOS
        protected float _costo;
        #endregion

        #region PROPIEDADES
        public float CostoLlamada
        {
            get { return this.CalcularCosto();}
        }
        #endregion

        #region CONSTRUCTORES
        public Local(Llamada unaLlamada, float costo): base(unaLlamada.NroOrigen,unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        #endregion

        #region METODOS
        private float CalcularCosto()
        {
            return this.Duracion*this._costo;
        }

        public void Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            base.Mostrar();
            cadena.AppendLine("Costo de llamada: " + this.CalcularCosto().ToString());
            Console.WriteLine(cadena);
        }
        #endregion
    }
}
