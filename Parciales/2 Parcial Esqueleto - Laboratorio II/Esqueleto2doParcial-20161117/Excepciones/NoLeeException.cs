using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoLeeException : Exception
    {
        public NoLeeException():base()
        {
        }

        public NoLeeException(string mensaje): base(mensaje)
        {
        }

    }
}
