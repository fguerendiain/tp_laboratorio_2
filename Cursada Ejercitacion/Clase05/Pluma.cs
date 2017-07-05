using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Pluma
    {
        #region ATRIBUTOS

        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #endregion

        #region CONSTRUCTORES
        
        public Pluma()
        {
            _marca = "SIN MARCA";
            _tinta = null;   
            _cantidad = 1;
        }
        public Pluma(string marca):this()
        {
            _marca = marca;
        }
        public Pluma(string marca, int cantidad):this(marca)
        {
            _cantidad = cantidad;
        }
        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            _marca = marca;
            _tinta = tinta;
            _cantidad = cantidad;
        }
        
        #endregion

            
        #region METODOS

        private string Mostrar()
        {
            return "La marca es " + this._marca + "\nla cantidad es " + this._cantidad + "\n" + Tinta.Mostrar(this._tinta);
        }

        #endregion
        
        
        #region OPERADORES

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return (pluma._tinta == tinta);
        }
        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta) 
        {
            if (Object.Equals(pluma._tinta,null))
            {
                pluma._tinta = tinta;
            }
            else if (pluma._tinta == tinta)
            {
                pluma._cantidad++;
            }
            else
            {
                Console.WriteLine("Las tintas no se pueden mezclar");
            }

            Pluma newPluma = new Pluma(pluma._marca, tinta, pluma._cantidad);
            return newPluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        { 
            if (pluma._cantidad == 0)
            {
                Console.WriteLine("\nNo queda tinta para sacar");
            }
            if ( pluma._tinta == tinta)
            {
                pluma._cantidad--;
                if (pluma._cantidad == 0)
                {
                    pluma._tinta = null;
                }
            }
            if (pluma._tinta != tinta)
            {
                Console.WriteLine("\nLa tinta a quitar no coincide");
            }

            return pluma;

              //puedo quitar si la tinta es igual a pluma._tinta si no es del mismo tipo no se puede sacar

              //si los tipos son iguales se decrementa la cantidad si la cantidad llega a 0 se vuelve null

        }
        
        

        #endregion

    }
}
