using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(8,8);
            Rectangulo r1 = new Rectangulo(8,6);

            //t1.altura = 8;
            //t1.baseT = 3;
            //r1.ladoUno = 3;
            //r1.ladoDos = 3;


            Console.WriteLine(t1.Mostrar());
            Console.WriteLine(r1.Mostrar());
            Rectangulo.Dibujar(r1);
            Console.WriteLine("\n\n\n");
            Triangulo.Dibujar(t1);
            Console.ReadLine();

        }
    }
}
