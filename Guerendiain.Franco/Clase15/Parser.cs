using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    public static class Parser
    {

        public static bool TryParse(string cadena, out int nro)
        { 
            return int.TryParse(cadena, out nro);
        }

        public static int Parse(string cadena)
        {
            try
            {

                return int.Parse(cadena);
            }
            catch (FormatException e)
            { 
                throw new ErrorParserException("por error de formato", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException("por tamaño del dato", e);
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