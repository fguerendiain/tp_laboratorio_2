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
            string draw = "";

            int height = t.altura;
            int width = t.baseT;

            int halfWidth = width / 2;
            int step = halfWidth / height;
            int distanceToCenter = 0;

            int drawFrom = 0;
            int drawTo = width;
            for (int row = 0; row < height; row++)
            {
                drawFrom = 0;
                drawTo = width;

                if (row != height - 1)
                {
                    distanceToCenter = row * step;
                    drawFrom = halfWidth - distanceToCenter;
                    drawTo = halfWidth + distanceToCenter;
                }

                for (int c = 0; c < width; c++)
                {
                    if (c >= drawFrom || c <= drawTo)
                    {
                        draw += "*";
                    }
                    else
                    {
                        draw += " ";
                    }
                }

                draw = "\n";
            }
            
            Console.Write(draw);
        }
    }
}
