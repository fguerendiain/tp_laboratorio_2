using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloPrimerParcial
{
    class Comercio
    {
        #region ATRIBUTOS
        private string _dueno;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;
        #endregion

        #region CONSTRUCTOR
        public Comercio(string dueno)
        {
            _dueno = dueno;
            _misArticulos = new List<Articulo>();
            _misVentas = new List<Venta>();
        }
        #endregion

        #region METODOS
        public void ComprarArticulo(Articulo articuloComprado)
        {
            foreach (Articulo t in this._misArticulos)
        	{
                if(t == articuloComprado)
                {
                    t.Stock = t + articuloComprado;
                    return;
                }
        	}
            this._misArticulos.Add(articuloComprado);
        }

        public static void MostarArticulos(Comercio ComercioAMostrar)
        {
            Console.WriteLine("Los productos existentes son");
            foreach (Articulo t in ComercioAMostrar._misArticulos)
            {
                Console.WriteLine(t.NombreYCodigo);
            }
        }

        public static void MostrarGanacia(Comercio ComercioParaResumen)
        {
            float ganancia = 0;
            foreach (Venta t in ComercioParaResumen._misVentas)
            {
                ganancia += t.RetornarGanancia();
            }

            Console.WriteLine(" la ganancia obtenida es de : " + ganancia);
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            Articulo aux =null;

            foreach (Articulo t in this._misArticulos)
            {
                if (t == articuloSolicitado)
                    aux = t;
            }

            if (!object.Equals(aux,null) && aux.HayStock(cantidad))
            {
                aux.Stock = aux - cantidad;
                this._misVentas.Add(new Venta(articuloSolicitado, cantidad));
            }
            else if (object.Equals(aux, null))
            {
                Console.WriteLine("El siguiente Producto no Existe en nuestro Comercio !!!\n" + articuloSolicitado.NombreYCodigo);
            }
            else
            {
                Console.WriteLine("El siguiente Producto no tiene stock para la venta!!!\n" + articuloSolicitado.NombreYCodigo);
            }
        }
        #endregion

    }
}
