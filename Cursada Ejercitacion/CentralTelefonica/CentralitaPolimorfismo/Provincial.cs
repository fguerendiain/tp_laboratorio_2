using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Provincial : Llamada
    {
        #region ATRIBUTOS
        protected Franja _franjaHoraria;
        #endregion

        #region PROPIEDADES
        public override float CostoLlamada
        {
            get { return this.CalcularCosto();}
        }
        #endregion

        #region CONSTRUCTORES
        public Provincial(Franja miFranja, Llamada unallamada):base(unallamada.NroOrigen, unallamada.NroDestino, unallamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino): base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        #endregion

        #region METODOS
        private float CalcularCosto()
        {
            float costo = 0f;

            switch(this._franjaHoraria)
            {
                case Franja.Franja_1 :
                    costo = 0.99f;
                    break;
                case Franja.Franja_2 :
                    costo = 1.25f;
                    break;
                case Franja.Franja_3 :
                    costo = 0.66f;
                    break;
            }

            return costo * this.Duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.Mostrar());
            cadena.AppendLine("Franja Horaria: " + this._franjaHoraria);
            cadena.AppendLine("Costo de llamada: " + this.CalcularCosto().ToString());
            return cadena.ToString();
        }

        public override bool Equals(Object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
