using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Ej
{
    class Fruta
    {
        #region ATRIBUTOS
        public float peso;
        public int volumen;
        #endregion

        #region CONSTRUCTORES
        public Fruta()
        {
            peso = Aleatorio(1);
            volumen = Aleatorio(2);
        }
        #endregion

        #region METODOS
        private static int Aleatorio(byte option)
        {
            switch (option)
            {
                case 1:
                    return new Random().Next(1,5);

                case 2:
                    return new Random().Next(1, 10);
            }
            return -1;
        }
        #endregion
    }
}
