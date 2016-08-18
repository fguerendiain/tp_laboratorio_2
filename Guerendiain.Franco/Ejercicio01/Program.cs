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
            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int max;
            int min;
            double prom;
            bool ok;

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                ok = int.TryParse(Console.ReadLine(), out num1);
            } while (!ok);
            do
            {
                Console.WriteLine("Ingrese el segundo numero: ");
                ok = int.TryParse(Console.ReadLine(), out num2);
            } while (!ok);
            do
            {
                Console.WriteLine("Ingrese el tercer numero: ");
                ok = int.TryParse(Console.ReadLine(), out num3);
            } while (!ok);
            do
            {
                Console.WriteLine("Ingrese el cuerto numero: ");
                ok = int.TryParse(Console.ReadLine(), out num4);
            } while (!ok);
            do
            {
                Console.WriteLine("Ingrese el quinto numero: ");
                ok = int.TryParse(Console.ReadLine(), out num5);
            } while (!ok);

            prom = (num1 + num2 + num3 + num4 + num5) / 5.0 ;

            max = Math.Max(num1, num2);
            min = Math.Min(num1, num2);


            Console.WriteLine("Numero Maximo: {0}", max);
            Console.WriteLine("Numero Minimo: {0}", min);
            Console.WriteLine("Promedio: {0}", prom);
        }
    }
}
