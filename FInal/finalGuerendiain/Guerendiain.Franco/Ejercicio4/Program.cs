using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guerendiain.Franco;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Galpon<Deposito> g1 = new Galpon<Deposito>();



            //ejercicio 5
            try
            {
                g1.Cantidad = 0;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
