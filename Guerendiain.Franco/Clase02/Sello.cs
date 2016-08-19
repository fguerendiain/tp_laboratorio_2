using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manualidades
{
    class Sello
    {
        //ATRIBUTOS
        public static string mensaje;
        public static ConsoleColor color;

        //METODOS
        public static string Imprimir()
        {
            string printMesage = "";
            
            Sello.TryParse(Sello.mensaje, out printMesage);
            
            return printMesage;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {

            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            int asteriscos;
            string asteriscosImpresos = "";
            string mensajeConAsteriscos = "";
            string leyend = "";

            leyend = Sello.mensaje;
            asteriscos = Sello.mensaje.Length;

            for (int i = 0; i < asteriscos; i++)
            {
                asteriscosImpresos += "*"; 
            }

            mensajeConAsteriscos = asteriscosImpresos + "**\n";
            mensajeConAsteriscos += "*" + leyend + "*\n";
            mensajeConAsteriscos += asteriscosImpresos + "**\n";

            return mensajeConAsteriscos;
        }
    
        private static bool TryParse(string mensaje, out string formatMesaje)
        {
            if (!string.IsNullOrEmpty(mensaje) && !string.IsNullOrWhiteSpace(mensaje))
            {
                formatMesaje = Sello.ArmarFormatoMensaje();
            }
            else
            {
                formatMesaje = "Mensaje invalido\n";
                return false;
            }
            return true;
        }
        
    }

}
