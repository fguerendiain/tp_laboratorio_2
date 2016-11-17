using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private string mensajeBase;

        public DniInvalidoException()
        { 
        }

        public DniInvalidoException(Exception e): base(e.Message)
        {
        }

        public DniInvalidoException(string message): base(message)
        {
        }

        public DniInvalidoException(string message, Exception e):this (message)
        {
            throw e;
        }

    }
}
