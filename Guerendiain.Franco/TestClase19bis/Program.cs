using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase19bis;

namespace TestClase19bis
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Beto","Cuevas","31757094", Empleado.EPuestoJerarquico.Accionista,4564321);
            Empleado e2 = new Empleado("Pedro", "Paredes", "45678978", Empleado.EPuestoJerarquico.Administración, 3521432);

            Xml<Empleado> expX = new Xml<Empleado>();
            Texto expT = new Texto(); 

            expX.Guardar("../../exportXML.xml", e2);
            expT.Guardar("../../exportTXT.txt", e1.ToString());

            Console.WriteLine(e1);
            Console.WriteLine("\n\n--------------------\n\n");

            expX.Leer("../../exportXML.xml",out e1);

            Console.WriteLine(e1);

            Console.ReadLine();

        }
    }
}
