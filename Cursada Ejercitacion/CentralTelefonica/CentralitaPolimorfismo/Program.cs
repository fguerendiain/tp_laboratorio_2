using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telefonica");

            Local l1 = new Local("Bs As", 30, "Cordoba", 2.65f);
            Provincial l2 = new Provincial("Jujuy", Franja.Franja_1, 21, "Salta");
            Local l3 = new Local("San Juan", 45, "La Rioja", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            central += l1;
            central.Mostrar();
            Console.WriteLine("AGREGO l1\n\n");

            central += l2;
            central.Mostrar();
            Console.WriteLine("AGREGO l2\n\n");

            central += l3;
            central.Mostrar();
            Console.WriteLine("AGREGO l3\n\n");

            central += l4;
            central.Mostrar();
            Console.WriteLine("AGREGO l4 QUE REPITE DATOS DE l2\n\n");


            //llamadas duplicadas
            central += l1;
            Console.WriteLine("INTENTO REAGREGAR l1\n\n");
            central += l3;
            Console.WriteLine("INTENTO REAGREGAR l3\n\n");

            central.Mostrar();

            central.OrdenarLlamadas();

            Console.WriteLine("\n-----------------------\n----------------------\nMUESTRO LAS LLAMADAS ORDENADAS\n\n");
            central.Mostrar();
            Console.WriteLine("\n-----------------------\n----------------------\nMUESTRO LAS LLAMADAS ORDENADAS\n\n");

            Console.ReadLine();            

        }
    }
}
