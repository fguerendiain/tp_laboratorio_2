using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Centralita central = new Centralita("Telefonica");

            Local l1 = new Local("Bs As",30,"Cordoba",2.65f);
            Provincial l2 = new Provincial("Jujuy",Franja.Franja_1,21,"Salta");
            Local l3 = new Local("San Juan", 45, "La Rioja", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3,l2);

            central.Llamadas.Add(l1);
            central.Llamadas.Add(l2);
            central.Llamadas.Add(l3);
            central.Llamadas.Add(l4);

            central.Mostrar();

            central.OrdenarLlamadas();

            central.Mostrar();

            Console.ReadLine();
        }
    }
}
