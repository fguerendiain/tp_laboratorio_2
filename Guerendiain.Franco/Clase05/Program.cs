using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta t1 = new Tinta();
            Tinta t2 = new Tinta(ETipoTinta.ConBrillito);
            Tinta t3 = new Tinta(ETipoTinta.China, ConsoleColor.Red);

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("MUESTRO LAS TINTAS\n");


            Console.WriteLine(Tinta.Mostrar(t1));
            Console.WriteLine(Tinta.Mostrar(t2));
            Console.WriteLine(Tinta.Mostrar(t3));

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("COMPARO IGUALDAD ENTRE TINTA Y TINTA\n");

            if (t1 == t2)
            {
                Console.WriteLine("Son iguales\n");
            }
            else
            {
                Console.WriteLine("No son iguales\n");
            }

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("MUESTRO LAS TINTAS CON WRITELINE\n");

            Console.WriteLine((string)t1);
            Console.WriteLine((string)t2);
            Console.WriteLine((string)t3);

            Pluma p1 = new Pluma("Pelican", t3, 8);

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("MUESTRO LA PLUMA CON WRITELINE\n");

            Console.WriteLine(p1);

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("COMPARO IGUALDAD ENTRE PLUMA Y TINTA\n");

            if (p1 == t3)
            {
                Console.WriteLine("Son iguales\n");
            }
            else
            {
                Console.WriteLine("No son iguales\n");
            }

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("SUMO OBJETO PLUMA CON TINTA\n");

            Pluma p2 = p1 + t3;
            Console.WriteLine(p2);

            Console.WriteLine("\n\n-----------------------------------\n");
            Console.WriteLine("SUMO OBJETO PLUMA POR DEFECTO CON TINTA\n");

            Pluma p3 = new Pluma();
            Pluma p4 = p3 + t2;
            Console.WriteLine(p4);

            p2 = p1 - t3;
            p4 = p3 - t2;
            p4 = p3 - t2;

            Console.WriteLine(p2);
            Console.WriteLine(p4);

            Console.ReadLine();
        
        }
    }
}
