using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEntidades
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Auto a1 = new Auto("Rojo", "Ferrari");
        //    Auto a2 = new Auto("Amarillo", "Porche");
        //    Auto a3 = new Auto("Negro", "BMW");
        //    Auto a4 = new Auto("Verde", "Ford");
        //    DepositoDeAutos da = new DepositoDeAutos(3);
        //    if ((da + a1))
        //    {
        //     Console.WriteLine("Se ha agregado el item!!!");
        //    }
        //    da.Agregar(a2);
        //    da.Agregar(a3);
        //    if (!da.Agregar(a4))
        //    {
        //       Console.WriteLine("No se pudo agregar el item!!!");
        //    }
        //    Console.WriteLine(da);
        //    da.Remover(a2);
        //    if (!(da - a4))
        //    {
        //       Console.WriteLine("No se pudo remover el item!!!");
        //    }
        //    Console.WriteLine(da);
        //    Console.ReadLine();
        //}

        //static void Main(string[] args)
        //{
        //    Cocina c1 = new Cocina(111, 12300, false);
        //    Cocina c2 = new Cocina(112, 15000, true);
        //    Cocina c3 = new Cocina(113, 5600, false);
        //    DepositoDeCocinas dc = new DepositoDeCocinas(5);
        //    dc.Agregar(c1);
        //    dc.Agregar(c2);
        //    if (!(dc + c3))
        //    {
        //        Console.WriteLine("No se pudo agregar el item!!!");
        //    }
        //    Console.WriteLine(dc);
        //    dc.Remover(c2);
        //    if (!(dc - c2))
        //    {
        //        Console.WriteLine("No se pudo remover el item!!!");
        //    }
        //    Console.WriteLine(dc);
        //    Console.ReadLine();
        //}

        static void Main(string[] args)
        {
            Cocina c1 = new Cocina(111, 12300, false);
            Cocina c2 = new Cocina(112, 15000, true);
            Cocina c3 = new Cocina(113, 5600, false);
            Auto a1 = new Auto("Rojo", "Ferrari");
            Auto a2 = new Auto("Amarillo", "Porche");
            Auto a3 = new Auto("Negro", "BMW");
            Auto a4 = new Auto("Verde", "Ford");
            Deposito<Cocina> dc = new Deposito<Cocina>(5);
            Deposito<Auto> da = new Deposito<Auto>(3);
            Deposito<Deposito<Auto>> ddA = new Deposito<Deposito<Auto>>(3);
            
            dc.Agregar(c1);
            dc.Agregar(c2);
            if (!(dc + c3))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            if ((da + a1))
            {
                Console.WriteLine("Se ha agregado el item!!!");
            }
            da.Agregar(a2);
            da.Agregar(a3);
            if (!da.Agregar(a4))
            {
                Console.WriteLine("No se pudo agregar el item!!!");
            }
            Console.WriteLine(dc);
            Console.WriteLine(da);
            dc.Remover(c2);
            if (!(dc - c2))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }
            da.Remover(a2);
            if (!(da - a4))
            {
                Console.WriteLine("No se pudo remover el item!!!");
            }

            ddA.Agregar(da);
            
            
            Console.WriteLine(dc);
            Console.WriteLine(da);
            Console.WriteLine(ddA);
            Console.ReadLine();
        }

    }
}
