using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parser.Parse("aghj");
            }
            catch (ErrorParserException e)
            {
                Console.WriteLine(e);
//                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}

/*
 Generar una clase estática llamada Parser.

1.Agregar un método TryParse(string, out int) : bool cuyo funcionamiento sea exactamente igual al de Int32.TryParse.
2.Agregar un método Parse(string) : int cuyo funcionamiento sea exactamente igual al de Int32.Parse.
    1.Capturar por separado las excepciones:
        1.FormatException: agregará al mensaje “... por error de formato”.
        2.OverflowException: agregará al mensaje “... por tamaño del dato”

3.En caso de falla, deberá devolver la excepción ErrorParserException generada por 
  el alumno, con el mensaje “El string no podrá ser convertido”. Utilizar la propiedad InnerException de la clase padre.

4.Dentro de ambos métodos, para convertir de String a Entero utilizar Int32.Parse. Controlar 
  las excepciones dentro de los métodos y luego lanzarlas.

NOTAS:
El método Parse deberá capturar y lanzar (throw) la excepción capturada.
 */