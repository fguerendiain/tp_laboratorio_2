using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto p0 = new Producto();
            Producto p1 = new Producto(3);
            Producto p2 = new Producto(2,"123456");
            Producto p3 = new Producto(9.12,"321654","Robocop");

            Producto p4 = new Producto(precio: 30, nombre: "tu vieja", codBarra: "0000xxxx1");

            double precio;
            string barcode;
            string name;

            Console.WriteLine("Ingrese un Nombre:\n");
            name = Console.ReadLine();
            Console.WriteLine("\nIngrese un Precio:\n");
            double.TryParse(Console.ReadLine(), out precio);
            Console.WriteLine("\nIngrese un Codigo de barra:\n");
            barcode = Console.ReadLine();
    
            Producto p5 = new Producto(precio,barcode,name);

            Console.WriteLine("\n\n");

            p0.Mostrar();
            p1.Mostrar();
            p2.Mostrar();
            p3.Mostrar();
            p4.Mostrar();
            p5.Mostrar();

            Console.ReadLine();
        
        }
    }
}
