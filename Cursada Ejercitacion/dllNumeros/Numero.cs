using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllNumeros
{
    public class Numero
    {
        protected int _numero;

        public int PNumero
        {
            get{ return _numero;}
        }

        public Numero(int nro)
        {
            if (nro < 0)
            {
                throw new Exception("Error de prueba LOCA LOCA LOCA\n\n");
            }
            else
            {
                this._numero = nro;
            }
        }

        public static int operator +(Numero nro1, Numero nro2)
        {
            return nro1._numero + nro2._numero;
        }

        public static int operator -(Numero nro1, Numero nro2)
        {
            return nro1._numero - nro2._numero;
        }

        public static double operator /(Numero nro1, Numero nro2)
        {
            return nro1._numero / nro2._numero;
        }

        public static int operator *(Numero nro1, Numero nro2)
        {
            return nro1._numero * nro2._numero;
        }

    }
}
