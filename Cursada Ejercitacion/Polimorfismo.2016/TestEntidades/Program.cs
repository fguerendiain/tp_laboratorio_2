using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno c1 = new ClaseUno("Primera Clase");
            ClaseDos c2 = new ClaseDos("Primera Clase", "Segunda Clase");
            ClaseTres c3 = new ClaseTres("Primera Clase", "Segunda Clase", "Tercera Clase");

            Console.WriteLine(c1.TipoClaseUno);
            Console.WriteLine(c2.TipoClaseDos);
            Console.WriteLine(c3.TipoClaseTres);

            Console.WriteLine(c1.MostrarClaseUno());
            Console.WriteLine(c2.MostrarClaseDos());
            Console.WriteLine(c3.MostrarClaseTres());


            Console.ReadLine();



        }
    }
}
