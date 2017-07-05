using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        #region ATRIBUTOS
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region PROPIEDADES
        public override float CalcularCostoDeProduccion
        {
            get { return (float)(this.Precio*0.42); }
        }

        #endregion

        #region CONSTRUCTORES
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros): base(codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros):this((int)p, p.Precio, p.Marca, litros){}
 
        #endregion

        #region METODOS
        private string MostrarGaseosa()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine((string)this);
            cadena.AppendLine("SABOR: " + this._litros);
                
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
            return this.MostrarGaseosa();
        }
        #endregion

    }
}
