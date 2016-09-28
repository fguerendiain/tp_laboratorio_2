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
            peso = new Random().Next(1,5);
            volumen = new Random().Next(1, 10);
        }
        #endregion
    }
}
