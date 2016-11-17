using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Asigna un nuevo valor para el atributo ancho de frente del objeto pasado como paramerto
    /// </summary>
    public static class TiendaExtencion
    {
        public static void SetAnchoDeFrente(this Tienda t, int nuevoFrente)
        {
            t.AnchoDeFrente = nuevoFrente;
        }
    }
}
