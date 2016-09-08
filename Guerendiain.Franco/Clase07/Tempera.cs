using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    public class Tempera
    {
        #region Atributos

        private ConsoleColor _color;
        private String _marca;
        private SByte _cantidad;

        #endregion

        #region Constructor

        public Tempera(ConsoleColor color, String marca, SByte cantidad)
        {
            this._color = color;
            this._cantidad = cantidad;
            this._marca = marca;
        }

        #endregion

        #region M�todos

        private string Mostrar()
        {
            string temp = "Color: " + this._color + "\n";
            temp += "Marca: " + this._marca + "\n";
            temp += "Cantidad: " + this._cantidad + "\n";
            return temp;
        }

        #endregion

        #region Sobrecarga de Operadores

        /// <summary>
        /// Operador de conversi�n impl�cito. Convierte una Tempera en
        /// su representaci�n a String.
        /// </summary>
        /// <param name="t">Objeto de tipo Tempera a convertir.</param>
        /// <returns>Representaci�n de tipo String del objeto Tempera.</returns>
        public static implicit operator String(Tempera t)
        {
            //REUTILIZO EL METODO PRIVADO DE INSTANCIA MOSTRAR.
            return t.Mostrar();
        }

        /// <summary>
        /// Operador de igualdad. Compara dos objetos de tipo
        /// Tempera por Marca y Color.
        /// </summary>
        /// <param name="t">Primer objeto de tipo Tempera a comparar.</param>
        /// <param name="t1">Segundo objeto de tipo Tempera a comparar.</param>
        /// <returns>TRUE, si las marcas y colores son iguales entre 
        /// los objetos de tipo Tempera.
        /// FALSE, caso contrario.</returns>
        public static Boolean operator ==(Tempera t, Tempera t1)
        {
            return t._marca == t1._marca && t._color == t1._color;
        }

        /// <summary>
        /// Operador de desigualdad. Compara dos objetos de tipo
        /// Tempera por Marca y Color.
        /// </summary>
        /// <param name="t">Primer objeto de tipo Tempera a comparar.</param>
        /// <param name="t1">egundo objeto de tipo Tempera a comparar.</param>
        /// <returns>TRUE, si las marcas y/o colores son distintas entre 
        /// los objetos de tipo Tempera.
        /// FALSE, caso contrario.</returns>
        public static Boolean operator !=(Tempera t, Tempera t1)
        {
            //REUTILIZO SOBRECARGA ==
            return !(t == t1);
        }

        /// <summary>
        /// Operador de adici�n. Suma una cantidad num�rica a la 
        /// cantidad del objeto de tipo Tempera.
        /// </summary>
        /// <param name="t">Objeto de tipo Tempera al que se le adicionar�
        /// una cantidad num�rica.</param>
        /// <param name="cant">Cantidad num�rica que se sumar� a la 
        /// cantidad del objeto de tipo Tempera.</param>
        /// <returns>Objeto de tipo Tempera con su cantidad incrementada.</returns>
        public static Tempera operator +(Tempera t, SByte cant)
        {
            t._cantidad += cant;
            return t;
        }

        /// <summary>
        /// Operador de adici�n. Suma las cantidades de dos objetos de tipo 
        /// Tempera, siempre y cuando las temperas sean iguales.
        /// </summary>
        /// <param name="t">Primer objeto de tipo Tempera a sumar.</param>
        /// <param name="t1">Segundo objeto de tipo Tempera a sumar.</param>
        /// <returns>Objeto de tipo Tempera con su cantidad sumada o no.</returns>
        public static Tempera operator +(Tempera t, Tempera t1)
        {
            //REUTILIZO SOBRECARGA ==
            if (t == t1)
            {
                //REUTILIZO SOBRECARGA +
                t += t1._cantidad;
            }
            return t;
        }

        #endregion
    }
}