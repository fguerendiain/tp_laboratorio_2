using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        #region ATRIBUTOS
        protected ETipoHarina _tipo;
        protected static bool DeConsumo;
        #endregion

        #region PROPIEDADES
        public override float CalcularCostoDeProduccion
        {
            get { return (float)(this.Precio*0.60); }
        }

        #endregion

        #region CONSTRUCTORES
        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo): base(codigoBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        public Harina(Producto p, ETipoHarina tipo):this((int)p, p.Precio, p.Marca, tipo){}
        #endregion

        #region METODOS
        private string MostrarHarina()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine((string)this);
            cadena.AppendLine("TIPO: " + this._tipo);
                
            return cadena.ToString();
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        public override string ToString()
        {
            return this.MostrarHarina();
        }
        #endregion

        #region ENUMERADO
        public enum ETipoHarina
        {
            Integral,
            CuatroCeros
        }
        #endregion

    }
}
