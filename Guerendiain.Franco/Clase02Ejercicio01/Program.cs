using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum;
            bool okUserInput;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                okUserInput = int.TryParse(Console.ReadLine(), out userNum);
                Console.WriteLine("\n");
            } while (!okUserInput);

            for (int i = 1; i <= userNum; i++)
            {
                if(((i % i++)== 0) && ((i % 1)== 0))
                {
                    if ((((i+1) % i) == 0))
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
