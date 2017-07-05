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
    class Conversor
    {
        public static string DecimalBinario(double decimalNumber)
        {
           string result = "";

           do
           {
               result = ((int)decimalNumber % 2) + result;
               decimalNumber = decimalNumber / 2;

           }while(decimalNumber > 1);

            return result;
        }



       public static double BinarioDecimal(string binaryNumber)
       {
           double convertedNumber = 0;
           bool parseOk;

           do{
               parseOk = double.TryParse(binaryNumber, out convertedNumber);

                if (!parseOk)
                {
                    Console.WriteLine("Ingrese un numero valido:\n");
                    binaryNumber = Console.ReadLine();
                }
           }while(!parseOk);

           convertedNumber = (double)Convert.ToInt32(binaryNumber,2);

           return convertedNumber;

        }
    }
}
