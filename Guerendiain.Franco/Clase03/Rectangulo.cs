using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Rectangulo
    {
        private int ladoUno;
        private int ladoDos;
        private double perimetro;
        private double superficie;

        public Rectangulo(int ladoUno, int ladoDos)
        {
            this.ladoUno = ladoUno;
            this.ladoDos = ladoDos;
            this.ObtenerDatos();
        }
        
        private void ObtenerDatos() 
        {
            this.perimetro = (this.ladoUno + this.ladoUno + this.ladoDos + this.ladoDos);
            this.superficie = this.ladoUno * this.ladoDos;
        }
        public string Mostrar()
        {
            string ret;
            ret = "\tRECTANGULO\nEl perimetro es: " + this.perimetro + "\nLa superficie es: " + this.superficie + "\n\n";
            return ret;
        }

        public static void Dibujar(Rectangulo r)
        {
            string horizontal = "";
            for (int i = 0; i < r.ladoUno; i++)
            {
                horizontal += "*";
            }
            for (int i = 0; i < r.ladoDos; i++)
            {
                horizontal += "\n" + horizontal;
            }
            Console.Write(horizontal);
        }

    }
}
