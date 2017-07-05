using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        #region ATRIBUTOS
        protected float _peso;
        protected static bool DeConsumo;
        #endregion

        #region PROPIEDADES
        public override float CalcularCostoDeProduccion
        {
            get { return (float)(this.Precio*0.33); }
        }

        #endregion

        #region CONSTRUCTORES
        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso): base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }
        #endregion

        #region METODOS
        private static string MostrarGalletita(Galletita g)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine((string)g);
            cadena.AppendLine("PESO: " + g._peso);
                
            return cadena.ToString();
        }

        public override string Consumir()
        {
            return "Comestible";
        }
        
        #endregion

        #region SOBRECARGA DE OPERADORES
        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }
        #endregion

    }
}
