using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        #region ATRIBUTOS
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;
        #endregion

        #region PROPIEDADES
        public override float CalcularCostoDeProduccion
        {
            get { return (float)(this.Precio*0.40); }
        }

        #endregion

        #region CONSTRUCTORES
        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor): base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }
        #endregion

        #region METODOS
        private string MostrarJugo()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine((string)this);
            cadena.AppendLine("SABOR: " + this._sabor);
                
            return cadena.ToString();
        }

        public override string Consumir()
        {
            return "Bebible";
        }
        
        #endregion

        #region SOBRECARGA DE OPERADORES
        public override string ToString()
        {
            return this.MostrarJugo();
        }
        #endregion

        #region ENUMERADO
        public enum ESaborJugo
        {
            Pasable,
            Asqueroso
        }
        #endregion


    }
}