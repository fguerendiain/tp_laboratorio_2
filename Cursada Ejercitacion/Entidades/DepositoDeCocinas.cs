using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        #region ATRIBUTOS
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion

        #region CONSTRUCTORES
        private DepositoDeCocinas()
        {
            this._lista = new List<Cocina>();
        }

        public DepositoDeCocinas(int capacidad)
            : this()
        {
            this._capacidadMaxima = capacidad;
        }
        #endregion

        #region METODOS
        public bool Agregar(Cocina a)
        {
            if (this + a)
            {
                return true;
            }
            return false;
        }

        public bool Remover(Cocina a)
        {
            if (this - a)
            {
                return true;
            }
            return false;
            
        }

        private int GetIndice(Cocina a)
        {
            foreach (Cocina t in this._lista)
            {
                if (t == a)
                {
                    return this._lista.IndexOf(t);
                }
            }
            return -1;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            if (d._capacidadMaxima > d._lista.Count)
            {
                d._lista.Add(a);
                return true;
            }
            return false;          
        }

        public static bool operator -(DepositoDeCocinas d, Cocina a)
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
            cadena.AppendLine("Listado de Cocinas");
            foreach (Cocina t in this._lista)
            {
                cadena.AppendLine(t.ToString());
            }
            return cadena.ToString();
        }
        #endregion

    }
}
