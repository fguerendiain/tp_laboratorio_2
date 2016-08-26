using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Producto
    {
        #region ATRIBUTOS
        private string codBarra;
        private double precio;
        private string nombre;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Crea una instancia de la clase Producto con los valores default
        /// </summary>
        public Producto()
        {
            this.precio = 0;
            this.codBarra = "sin nombre";
            this.nombre = "sin nombre";
        }
 
        /// <summary>
        /// Genera una instancia y recibe el precio
        /// </summary>
        /// <param name="precio">Precio del producto</param>
        public Producto(double precio): this()
        {
            
            this.precio = precio;
        }

        /// <summary>
        /// Genera una instancia y recibe el nombre
        /// </summary>
        /// <param name="nombre">Nombre del producto</param>
        public Producto(string nombre): this()
        {

            this.nombre = nombre;
        }

        /// <summary>
        /// Genera una instancia y recibe el precio y codigo de barra
        /// </summary>
        /// <param name="precio">Precio del producto</param>
        /// <param name="codBarra">Codigo numerico identificador del producto</param>
        public Producto(double precio, string codBarra): this(precio)
        {
            this.codBarra = codBarra;
        }

        /// <summary>
        /// Genera una instancia y recibe el precio y el nombre
        /// </summary>
        /// <param name="precio">Precio del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        public Producto(string nombre, double precio): this(precio)
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Genera una instancia y recibe el precio, codigo de barra y nombre
        /// </summary>
        /// <param name="precio">Precio del producto</param>
        /// <param name="codBarra">Codigo numerico identificador del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        public Producto(double precio, string codBarra, string nombre)
        {
            this.precio = precio;
            this.codBarra = codBarra;
            this.nombre = nombre;
        }
        
        

        
        #endregion

        #region METODOS

        /// <summary>
        /// Muestra las caracteristicas del producto
        /// </summary>
        public void Mostrar()
        { 
            Console.WriteLine("C.Barra\t: {0}\nNombre\t: {1}\nPrecio\t: ${2:0.00}\n\n",this.codBarra,this.nombre,this.precio);
        }

        #endregion

    }


}
