using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrimerParcial
{
    class Venta
    {
        #region ATRIBUTOS
        private Articulo _articuloVendido;
        private int _cantidad;
        #endregion

        #region CONSTRUCTOR
        public Venta(Articulo articuloVendido, int cantidad)
        {
            _articuloVendido = articuloVendido;
            _cantidad = cantidad;
        }
        #endregion

        #region METODOS
        public float RetornarGanancia()
        {
            return this._articuloVendido.PrecioVenta*this._cantidad;
        }
        #endregion

    }
}
