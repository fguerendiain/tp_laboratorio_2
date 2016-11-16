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

        public DniInvalidoException(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        public DniInvalidoException(string message)
        {
            this.mensajeBase = message;
        }

        public DniInvalidoException(string message, Exception e):this (message)
        {
            new DniInvalidoException(e);
            Console.WriteLine(this.mensajeBase);
        }

    }
}
