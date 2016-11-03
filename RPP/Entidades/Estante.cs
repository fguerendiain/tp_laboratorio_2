using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region ATRIBUTOS
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        #endregion

        #region PROPIEDADES
        public float ValorEstanteTotal
        {
            get { return this.GetValorEstante(); }
        }
        #endregion

        #region CONSTRUCTORES
        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad): this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region METODOS
        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("CAPACIDAD: " + e._capacidad);
            foreach (Producto t in e.GetProductos())
            {
                cadena.AppendLine(t.ToString());
            }
            return cadena.ToString();
        }

        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float resultado = 0;

            foreach (Producto t in this.GetProductos())
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (t is Galletita)
                            resultado += t.Precio;
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (t is Gaseosa)
                            resultado += t.Precio;
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (t is Harina)
                           resultado += t.Precio;
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (t is Jugo)
                           resultado += t.Precio;
                        break;
                    case Producto.ETipoProducto.Todos:
                           resultado += t.Precio;
                        break;
                }
            }
            return resultado;
        }

        private float GetValorEstante()
        {
            return GetValorEstante(Producto.ETipoProducto.Todos);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES

        public static bool operator ==(Estante e, Producto prod)
        {
            foreach (Producto t in e.GetProductos())
            {
                if (t == prod)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {

            for (int i = 0; i < e.GetProductos().Count; i++)
            {
                switch (tipo)
                {
                    case Producto.ETipoProducto.Galletita:
                        if (e.GetProductos()[i] is Galletita)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Gaseosa:
                        if (e.GetProductos()[i] is Gaseosa)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Harina:
                        if (e.GetProductos()[i] is Harina)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Jugo:
                        if (e.GetProductos()[i] is Jugo)
                            e.GetProductos().Remove(e.GetProductos()[i]);
                        break;
                    case Producto.ETipoProducto.Todos:
                        e.GetProductos().Clear();
                        break;
                }
                
            }
            return e;
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            if(e==prod)
            {
                e.GetProductos().Remove(prod);
            }
            return e;
        }
        
        public static bool operator +(Estante e, Producto prod)
        {
            if ((e.GetProductos().Count < e._capacidad) && (e != prod))
            {
                e.GetProductos().Add(prod);
                return true;
            }
            return false;
        }

        #endregion
    }
}
