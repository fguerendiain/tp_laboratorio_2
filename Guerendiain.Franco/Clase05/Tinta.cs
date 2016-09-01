using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Tinta
    {
        #region ATRIBUTOS

        private ETipoTinta _tipo;
        private ConsoleColor _color;
        
        #endregion

        #region CONSTRUCTORES

        public Tinta()
        {
            _tipo = ETipoTinta.Comun;
            _color = ConsoleColor.Green;
        }

        public Tinta(ETipoTinta tipo):this()
        {
            _tipo = tipo;
        }

        public Tinta(ETipoTinta tipo, ConsoleColor color)
        {
            _tipo = tipo;
            _color = color;
        }

        #endregion

        #region METODOS

        private string Mostrar()
        {
            return "El color es " + this._color.ToString() + "\ny el tipo es " + this._tipo.ToString() + "\n";
        }

        public static string Mostrar(Tinta objTinta)
        {
            return objTinta.Mostrar();
        }

        #endregion

        #region OPERADORES
        
        public static bool operator == (Tinta t1,Tinta t2)
        {
            return t1._color == t2._color && t1._tipo == t2._tipo;
        }
        public static bool operator != (Tinta t1,Tinta t2)
        {
            return !(t1 == t2);
        }

        #endregion

        #region OPERADOR DE CONVERSION

        public static explicit operator string (Tinta t1)
        {
            return t1.Mostrar();
        }

        #endregion
    }
}
