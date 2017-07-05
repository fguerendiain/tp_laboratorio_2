using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15
{
    class ErrorParserException: Exception
    {
        public ErrorParserException(string cadena, Exception e): base(cadena, e)
        {
 
        }

        public override string ToString()
        {
            return this.GetType() + ": " + this.Message + " ---> \n\n-----INNEREXCEPTION------\n" + this.InnerException.ToString() + "\n\n-----STACKTRACE-----\n" + this.StackTrace;
        }

	
    }
}
