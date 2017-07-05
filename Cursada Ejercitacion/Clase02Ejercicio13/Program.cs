/*
 *  13. Desarrollar una clase llamada ‗Conversor’, que posea dos métodos de clase (estáticos):
 *  string DecimalBinario(double). Convierte un número de decimal a binario. 
 *  double BinarioDecimal(string). Convierte un número binario a decimal.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double decimalNumber = 156;
            string binaryNumber = "";

            binaryNumber = Conversor.DecimalBinario(decimalNumber);

            Console.WriteLine(binaryNumber + "\n");

            decimalNumber = Conversor.BinarioDecimal(binaryNumber);

            Console.WriteLine(decimalNumber);

            Console.ReadLine();

        }
    }
}
