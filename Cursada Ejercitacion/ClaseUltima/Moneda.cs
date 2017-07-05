using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUltima
{
    public class Moneda
    {
        #region ---------------ATRIBBUTOS--------------
        private ELado _lado;
        #endregion

        #region ---------------PROPIEDADES-------------
        public ELado Lado
        {
            get { return this._lado;}
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Moneda(){}
        #endregion

        #region -----------------METODOS---------------
        public void Tirar(ELado lado)
        {
            int rnd;
            Random r = new Random();
            rnd = r.Next(0, 2);
            switch (rnd)
            { 
                case 0:
                this._lado = ELado.Cara;
                break;

                case 1:
                this._lado = ELado.Cruz;
                break;
            }

            if (this._lado == lado)
            {
                this.Ganar();
            }
            else
            {
                this.Perder(this.Lado);
            }
        }
        #endregion

        #region ----------------EVENTOS----------------
        public event DelMonedaWins Ganar;

        public event DelMonedaLose Perder;
        #endregion

    }
        //--------------------------FUERA DE LA CLASE------------------------------    

        #region ---------------DELEGADO----------------
        public delegate void DelMonedaWins();
        
        public delegate void DelMonedaLose(ELado lado);

        #endregion

        #region ----------------ENUMERADOS-------------
        public enum ELado
        {
            Cara,
            Cruz
        }
        #endregion

        

}
