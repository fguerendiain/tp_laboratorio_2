using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Otra;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "a tu mama le dieron murra entre muchos "; //8
            int esPar = 48;
            String nulo = null;

            
            Persona p1 = new Persona("Pepe","Lotas",21,Entidades.Alumnos.ESexo.Masculino);
            PersonaExternaHeredada pEx2 = new PersonaExternaHeredada("Rosa", "Melano", 32, Entidades.Externa.ESexo.Femenino);
            PersonaExternaOtra pExOt3 = new PersonaExternaOtra("Flor", "De LA V", 52, Entidades.Externa.Otra.ESexo.Indefinido);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(pEx2.ToString());

            MetodoExtencion.MostrarPersona(p1);

            Console.WriteLine(pExOt3.Mostrar());

            Console.WriteLine(cadena.ContarPalabras());

            Console.WriteLine(esPar.EsPar());

            Console.WriteLine(MetodoExtencion.isNull(nulo));


            Console.ReadLine();
        }
    }
}
