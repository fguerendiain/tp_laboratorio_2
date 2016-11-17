using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardaException : Exception
    {
        public NoGuardaException():base()
        { 
        }
        
        public NoGuardaException(string mensaje):base(mensaje)
        {
        }

        public NoGuardaException(string mensaje, Exception innerException): base(mensaje,innerException)
        {
        }

    }
}
