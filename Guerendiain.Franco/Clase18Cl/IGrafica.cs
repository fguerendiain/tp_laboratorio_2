using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase18Cl
{
    public interface IGrafica
    {
        void MostrarEnGUI(string cadena);

        bool EscribirTxT(string path, Empleado e);
    }

}
