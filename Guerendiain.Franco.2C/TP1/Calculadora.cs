using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {
        /// <summary>
        /// Realiza la operacion matematica deseada
        /// </summary>
        /// <param name="numero1">Recibe el operando1</param>
        /// <param name="numero2">Recibe el operando1</param>
        /// <param name="operador">Recibe el operador</param>
        /// <returns></returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            switch (validarOperador(operador))
            {
                case "+" :
                    return numero1 + numero2;
            
                case "-" :
                    return numero1 - numero2;
            
                case "*" :
                    return numero1 * numero2;

                case "/" :
                    if (numero2.getNumero() != 0)
                    {
                        return numero1 / numero2;
                    }
                    return 0;

                default :
                    return 0;
            }

        }

        /// <summary>
        /// Valida el operador
        /// </summary>
        /// <param name="operador">Recibe un operador</param>
        /// <returns>Devuelve el operador correcto o + en caso de error como valor por defecto</returns>
        public static string validarOperador(string operador)
        {
            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            return "+";
        }
    }
}
