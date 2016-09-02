using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        private double numero;

        #region CONSTRUCTORES

        public Numero()
        {
            numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            setNumero(numero);
        }

        #endregion

        #region METODOS

        public double getNumero()
        {
            return this.numero;
        }

        private void setNumero(string numero)
        {
            this.numero = validarNumero(numero);
        }

        private double validarNumero(string numeroString)
        {   
            double numero = 0;
            if(double.TryParse(numeroString,out numero))
            {
                return numero;
            }
            return numero;
        }

        #endregion
    }
}
