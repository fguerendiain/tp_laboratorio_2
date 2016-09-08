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

            foreach (Tempera t in temperaArray)
            {
                 Console.WriteLine(t);
            }

            temperaArray[0] += temperaArray[4];

            Console.WriteLine(temperaArray[0]);

            Paleta p = 3;

            p += temperaArray[0];
            p += temperaArray[1];
            p += temperaArray[2];


            Console.ReadLine();
        }
    }
}
