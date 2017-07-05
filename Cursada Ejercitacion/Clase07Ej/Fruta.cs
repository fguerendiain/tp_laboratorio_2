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
        private static Random _rnd;
        #endregion

        #region CONSTRUCTORES
        static Fruta()
        {
            _rnd = new Random();
        }
        
        public Fruta()
        {
            peso = Fruta._rnd.Next(1,5);
            volumen = Fruta._rnd.Next(1, 10);
        }
        #endregion
    }
}
