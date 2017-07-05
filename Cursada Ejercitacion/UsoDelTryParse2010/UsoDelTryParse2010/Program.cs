using System;
using System.Collections.Generic;
using System.Text;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool estaOK;
            int numero;

            do {
                //PIDO EL INGRESO DE UN NÚMERO
                Console.WriteLine("Ingrese un número ");

                //SI NO COINCIDE EL TIPO EL MÉTODO TRYPARSE
                //RETORNA FALSE, CASO CONTRARIO RETORNA TRUE Y
                //COLOCA EL VALOR INGRESADO EN LA VARIABLE DE SALIDA
                estaOK = int.TryParse(Console.ReadLine(), out numero);

                if (!estaOK)
                    Console.WriteLine("Error en el tipo de dato.");

            }while(!estaOK );

            Console.WriteLine("El número ingresado fue: {0}", numero);
            Console.ReadLine();
        }
    }
}
