using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manualidades;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa el mensaje del sello
            Console.WriteLine("Ingrese el mensaje del sello:\n");
            Sello.mensaje = Console.ReadLine();
            Console.WriteLine("\n");

            //Setea color
            Sello.color = ConsoleColor.Red;

            //Cambia color
            Sello.ImprimirEnColor();
            
            //Imprime sello
            Console.WriteLine(Sello.Imprimir());

            //Borra mensaje
            Sello.Borrar();

            //Imprime sello
            Console.WriteLine(Sello.Imprimir());

            //Pausa
            Console.WriteLine("Precione una tecla para continuar\n");
            Console.ReadKey();


        }
    }
}
