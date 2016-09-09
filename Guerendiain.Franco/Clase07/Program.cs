using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colores = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Red };
            string[] marca = { "sancor", "coca cola", "sancor" };
            sbyte[] cantidad = {1,2,3};

            Tempera[] temperaArray = new Tempera[3];

            for (int i = 0; i < temperaArray.Length; i++)
            {
                temperaArray[i] = new Tempera(colores[i],marca[i],cantidad[i]);
            }

            //foreach (Tempera t in temperaArray)
            //{
            //     Console.WriteLine(t);
            //}

            //temperaArray[0] += temperaArray[2];

            //Console.WriteLine(temperaArray[0]);

            Paleta p1 = 3;

            p1 += temperaArray[2];
            p1 += temperaArray[1];
            p1 += temperaArray[0];

            Paleta p2 = 2;

            p2 += temperaArray[1];
            p2 += temperaArray[2];

            p1 += p2;

            //Console.WriteLine((string)p1);

            temperaArray[0].Marca = "Parapente";
            string marcaCambiar = temperaArray[1].Marca;
            temperaArray[2].Marca = marcaCambiar;

            Console.WriteLine(temperaArray[0]);
            Console.WriteLine(temperaArray[1]);
            Console.WriteLine(temperaArray[2]);

            temperaArray[0].Precio = 23;

            Console.WriteLine(p1.cantidadColores);

            Console.WriteLine(p1[0]);

            Console.ReadLine();
        }
    }
}
