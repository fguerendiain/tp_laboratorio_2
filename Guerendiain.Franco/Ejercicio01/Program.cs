using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            int max;
            int min;
            double prom;
            bool ok;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ",i+1);
                ok = int.TryParse(Console.ReadLine(), out num1);
                
            }
            

            prom = (num1 + num2 + num3 + num4 + num5) / 5.0 ;

            max = Math.Max(num1, num2);
            min = Math.Min(num1, num2);


            Console.WriteLine("Numero Maximo: {0}", max);
            Console.WriteLine("Numero Minimo: {0}", min);
            Console.WriteLine("Promedio: {0}", prom);
        }
    }
}
