using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase20DB;

namespace TestClase20DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Mercedez", 45, 112);

            p1.Agregar();

            List<Persona> lista = new List<Persona>();
            
            lista = Persona.TraerPersonas();

            foreach (Persona t in lista)
            {
                Console.WriteLine(t.ToString());
            }

            Console.ReadLine();
        }
    }
}
