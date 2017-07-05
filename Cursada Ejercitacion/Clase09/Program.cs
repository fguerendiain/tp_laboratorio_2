using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiculosLib;

namespace Clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lav = new Lavadero(10, 15, 5);

            lav += new Auto(4, "asd123", 4, EMarcas.Fiat);
            lav += new Auto(4, "asg523", 4, EMarcas.Fiat);
            lav += new Auto(4, "qwe345", 4, EMarcas.Honda);
            lav += new Camion(123, "zxc123", 4, EMarcas.Scania);
            lav += new Moto(125, "poi123", 2, EMarcas.Zanella);

            lav -= lav.Lista[0];
            lav.Lista.Sort(Lavadero.OrdenarPorPatente);

            lav.Lista.Sort(Lavadero.OrdenarPorMarca);

            Console.WriteLine(lav.MostrarTotalFacturado());
            Console.ReadLine();
        }
    }
}
