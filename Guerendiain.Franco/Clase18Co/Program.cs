using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18Cl;

namespace Clase18Co
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Franco", "Guerendiain", "31757094", EPuestoJerarquico.Sistemas, 2);
            Vista v1 = new Vista();
                        
            v1.Main(e1);

            Console.ReadLine();
        }
    }
}
