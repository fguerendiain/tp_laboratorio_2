using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerendiain.Franco
{
    //ejercicio 4
    public class Galpon<T>
    {
        List<T> lista;

        private int _cantidad;

        public int Cantidad
        {
            set
            {
                if (value.GetType() == typeof(int))
                {
                    if (value == 0)
                    {
                        throw new ArgumentException();
                    }

                    this._cantidad = value;
                }
            }

            }
    }
}
