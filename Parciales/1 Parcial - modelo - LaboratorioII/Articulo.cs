using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrimerParcial
{
    class Articulo
    {
        #region ATRIBUTOS
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;
        #endregion

        #region PROPIEDADES
        public string NombreYCodigo
        {
            get { return this._codigo + "--" + this._nombre.ToUpper(); }
        }

        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = this._precioCosto * (float)1.30;
            }
        }

        public float PrecioVenta
        {
            get {return _precioVenta;}
        }

        public int Stock
        {
            set { _stock = value;}
        }
        #endregion

        #region CONSTRUCTOR
        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            PrecioCosto = precioCosto;
            _stock = cantidad;
        }
        #endregion

        #region METODOS
        public bool HayStock(int cantidad)
        {
            return (this._stock >= cantidad);
        }
        #endregion

        #region SOBRECARGA OPERADORES
        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            return ((articuloUno._nombre == articuloDos._nombre) && (articuloUno._codigo== articuloDos._codigo));
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno == articuloDos);
        }

        public static int operator -(Articulo articuloUno, int cantidad)
        {
            return articuloUno._stock - cantidad;
        }

        public static int operator +(Articulo articuloUno,Articulo articuloDos)
        {
            return articuloUno._stock + articuloDos._stock;
        }

        #endregion
    }

}
