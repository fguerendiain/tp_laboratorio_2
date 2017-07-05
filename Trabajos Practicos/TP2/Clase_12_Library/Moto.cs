using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Moto : Vehiculo
    {
        #region CONSTRUCTORES
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(marca, patente, color){}
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        protected override short CantidadRuedas
        {
            get
            {
                return 2;
            }
        }
        #endregion

        #region SOBRECARGA DE METODOS
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("RUEDAS : " + this.CantidadRuedas);
            sb.AppendLine("--------------------");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
