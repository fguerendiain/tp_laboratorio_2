using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class Local : Llamada
    {

        #region ATRIBUTOS
        protected float _costo;
        #endregion

        #region PROPIEDADES
        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Costo de llamada: " + this.CalcularCosto().ToString());
            return cadena.ToString();
        }

        public override bool Equals(Object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion


    }
}
