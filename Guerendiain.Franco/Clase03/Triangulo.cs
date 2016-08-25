using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Triangulo
    {
        private int baseT;
        private int altura;
        private double superficie;

        public Triangulo(int baseT, int altura)
        {
            this.altura = altura;
            this.baseT = baseT;
            this.ObtenerDatos();
        }
        
        
        private void ObtenerDatos()
        {
            this.superficie = (this.baseT * this.altura) / 2;
        }
        public string Mostrar()
        {
            string ret;
            ret = "\tTRIANGULO\nLa superficie es: " + this.superficie + "\n\n";
            return ret;
        }

        public static void Dibujar(Triangulo t)
        {
            string horizontal = "";

            while (horizontal.Length != t.baseT-1)
            {
                horizontal = "*\n" + horizontal;
            }
            
            //for (int i = 0; i < t.baseT; i++)
            //{
            //    horizontal += "*";
            //}
            //for (int i = 0; i < t.altura; i++)
            //{
            //    horizontal = "\n" + horizontal;
            //}
            Console.Write(horizontal);
        }


    }
}
