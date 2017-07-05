using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 2
            Stack<Double> pila = new Stack<double>();
            Queue<Double> pilaAux = new Queue<double>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            foreach (Double t in pila)
            {
                pilaAux.Enqueue(pila.Pop());
            }
            foreach (Double t in pilaAux)
            {
                pila.Push(pilaAux.Dequeue());
            }
            
            // ------------------------------------------

        }
    }
}
