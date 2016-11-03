using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAFIP> listaAfip = new List<IAFIP>();
            List<IARBA> listaArba = new List<IARBA>();

            Carreta c1 = new Carreta(32);

            Comercial com1 = new Comercial(40, 1000, 33);
            Deportivo dep1 = new Deportivo(50, "DGH321", 60);
            Familiar fam1 = new Familiar(100, "TKB524", 7);
            Privado pri1 = new Privado(60, 2000, 10);

            listaAfip.Add(com1);
            listaAfip.Add(dep1);
            listaAfip.Add(pri1);

            listaArba.Add(com1);
            listaArba.Add(dep1);
            listaArba.Add(pri1);

            
            Console.WriteLine("\n\n-------------------\n");
            Console.WriteLine("Carreta");
            c1.MostrarPrecio();
            Console.WriteLine("\n\n-------------------\n");
            Console.WriteLine("Avion Comercial");
            com1.MostrarPrecio();
            Console.WriteLine(Gestion.MostrarImpuestoNacional(com1));
            Console.WriteLine("\n\n-------------------\n");
            Console.WriteLine("Deportivo\n");
            dep1.MostrarPrecio();
            Console.WriteLine(Gestion.MostrarImpuestoNacional(dep1));
            Console.WriteLine("\n\n-------------------\n");
            Console.WriteLine("Familiar\n");
            fam1.MostrarPrecio();
            Console.WriteLine("\n\n-------------------\n");
            Console.WriteLine("Privado\n");
            pri1.MostrarPrecio();
            Console.WriteLine(Gestion.MostrarImpuestoNacional(pri1));

            Console.WriteLine("\n\n-------------------------\n");
            Console.WriteLine("IMPRIMO LIST<IAFIP> UNA LISTA CON FOREACH");
            foreach (IAFIP t in listaAfip)
            {
                Console.WriteLine("Impuesto\n" + t.CalcularImpuesto() + "\n\n");
            }

            Console.WriteLine("\n\n-------------------------\n");
            Console.WriteLine("IMPRIMO LIST<IARBA> UNA LISTA CON FOREACH");
            foreach (IARBA t in listaArba)
            {
                Console.WriteLine("Impuesto\n" + t.CalcularImpuesto() + "\n\n");
            }
            
            
            Console.ReadLine();

        
        }
    }
}
