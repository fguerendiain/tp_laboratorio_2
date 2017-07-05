using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Ej
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajon caj = new Cajon(10);
            bool exit = true;

            for (int i = 0; i < 5; i++)
            {
                caj.AgregarFruta(new Fruta());
            }

            do
            {
                Console.WriteLine("FRUTAS MANNAGER\n\n" + caj.MostrarContenido() + "(A) Agregar fruta\n(B) Quitar fruta\n\n");
                Console.ReadLine();

            } while (exit);
        }
    }
}




/*meter programa en un while para que itere hasya que el usuario decida
 mostrar el contenido de _frutas y menu para agregar o borrar*/