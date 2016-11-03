using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        #region ATRIBUTOS
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region PROPIEDADES
        public int Codigo
        {
            get{return _codigo;}        
        }

        public bool EsIndustrial
        {
            get { return _esIndustrial;}
        }

        public double Precio
        {
            get { return _precio;}
        }
        #endregion

        #region CONSTRUCTORES
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Cocina a, Cocina b)
        {
            if (a.Codigo == b.Codigo)
                return true;

            return false;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is Cocina && ((Cocina)obj) == this;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append("Codigo: " + this.Codigo);
            cadena.Append(" - Precio: " + this.Precio);
            cadena.Append(" - Es industrial? " + this.EsIndustrial);

            return cadena.ToString();
        }
        #endregion
    }
}
