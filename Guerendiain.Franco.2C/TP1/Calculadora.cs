using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            switch (validarOperador(operador))
            {
                case "+" :
                    return numero1.getNumero() + numero2.getNumero();
                break;
            
                case "-" :
                    return numero1.getNumero() - numero2.getNumero();
                break;
            
                case "*" :
                    return numero1.getNumero() * numero2.getNumero();
                break;

                case "/" :
                    if (numero2.getNumero() != 0)
                    {
                        return numero1.getNumero() / numero2.getNumero();
                    }
                    return 0;
                break;

                default :
                return 0;
            }

        }
        public string validarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            return "+";
        }
    }
}
