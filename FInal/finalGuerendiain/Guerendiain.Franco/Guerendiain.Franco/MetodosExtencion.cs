using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerendiain.Franco
{
    public static class MetodosExtencion
    {

        //Ejercicio 1--------------------------------

        public static bool EsPar(this Int32 nro)
        {
            if (nro % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool EsImpar(this Int32 nro)
        {
            return !EsPar(nro);
        }

        //-------------------------------------------

    }
}
