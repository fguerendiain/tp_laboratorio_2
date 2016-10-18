using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region ATRIBUTOS
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        #endregion

        #region PROPIEDADES
        public abstract float CalcularCostoDeProduccion{ get; }

        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }

        public float Precio
        {
            get { return this._precio; }
        }

        #endregion

        #region CONSTRUCTORES
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion

        #region METODOS
        private static string MostrarProducto(Producto p)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("MARCA: " + p.Marca);
            cadena.AppendLine("CóDIGO DE BARRAS: " + p._codigoBarra);
            cadena.Append("PRECIO: " + p.Precio);

            return cadena.ToString();
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            return (prodUno.GetType() == prodDos.GetType()) && (prodUno.Marca == prodDos.Marca) && (prodUno._codigoBarra == prodDos._codigoBarra);
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            return (prodUno.Marca == marca);
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public override bool Equals(object obj)
        {
            return (this == ((Producto)obj));
        }

        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return Producto.MostrarProducto(p);
        }
        #endregion

        #region ENUMERADO
        public enum EMarcaProducto
        {
            Favorita,
            Pitusas,
            Diversión,
            Naranjú,
            Swift
        }

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }
        #endregion

    }
}