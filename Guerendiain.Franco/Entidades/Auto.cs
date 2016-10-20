using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        #region ATRIBUTOS
        private string _color;
        private string _marca;
        #endregion

        #region PROPIEDADES
        public string Color
        {
            get { return _color; }
        }

        public string Marca
        {
            get { return _marca; }
        }
        #endregion

        #region CONSTRUCTORES
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Auto a, Auto b)
        {
            if(a.Marca == b.Marca && a.Color == b.Color)
                return true;
            return false;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a==b);
        }

        public override bool Equals(Object obj)
        {
            return obj is Auto && ((Auto)obj)==this;
        }

        public override string ToString()
        {
            StringBuilder cadena= new StringBuilder();
            cadena.Append("Marca: " + this._marca + " - Color: " + this._color);

            return cadena.ToString();
        }
        #endregion
    }
}
