using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        #region ATRIBUTOS
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region CONSTRUCTORES
        private Deposito()
        { 
            this._lista = new List<T>();
        }

        public Deposito(int capacidad): this()
        {
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region METODOS
        public bool Agregar(T a)
        {
            if (this + a)
            {
                return true;
            }
            return false;
        }

        public bool Remover(T a)
        {
            if (this - a)
            {
                return true;
            }
            return false;
            
        }

        private int GetIndice(T a)
        {
            foreach (T t in this._lista)
            {
                if (t.Equals(a))
                {
                    return this._lista.IndexOf(t);
                }
            }
            return -1;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator +(Deposito<T> d, T a)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }
            return false;          
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            if (d.GetIndice(a) != -1)
            {
                d._lista.Remove(a);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Capacidad máxima: " + this._capacidadMaxima);
            cadena.AppendLine("LISTADO DE " + typeof(T).Name.ToUpper() + "S");
            foreach (T t in this._lista)
            {
                cadena.AppendLine(t.ToString());
            }
            return cadena.ToString();

        
        }
        #endregion
    }
}
