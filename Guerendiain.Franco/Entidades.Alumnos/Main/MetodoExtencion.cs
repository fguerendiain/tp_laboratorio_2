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
    // 1 · las clases de metodos de extencion deben ser estaticas
    public static class MetodoExtencion
    {
        //2 - los metodos dentro de una clase de extencion deben ser estaticos
        public static void MostrarPersona(Persona p)
        {
            Console.WriteLine(p.ToString());
        }

        public static string Mostrar(this PersonaExternaOtra p)
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append("NOMBRE: " + p.Nombre + " - ");
            cadena.Append("APELLIDO: " + p.Apellido + " - ");
            cadena.Append("EDAD: " + p.Edad + " - ");
            cadena.AppendLine("SEXO: " + p.Sexo);

            return cadena.ToString();
        }

        public static bool isNull(this object o)
        {
            if (o.Equals(null))
                return true;
            return false;
        }

        public static int ContarPalabras(this string s)
        {
            int words = 0;

            foreach (char t in s)
            {
                if (t.CompareTo(' ') == 0)
                {
                    words++;
                }
            }
            
            return words;
        }

        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
                return true;
            return false;
        }

    }
}
