using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            //HARDCODEO DATOS
            ConsoleColor[] colores = { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Red };
            string[] marca = { "sancor", "coca cola", "sancor" };
            sbyte[] cantidad = {1,2,3};

            //INSTANCIO TEMPERAS EN UN ARRAY DE TEMPERAS
            Tempera[] temperaArray = new Tempera[3];

            //CARGO LOS OBJETOS TEMPERA CON EL HARDCODEO
            for (int i = 0; i < temperaArray.Length; i++)
            {
                temperaArray[i] = new Tempera(colores[i],marca[i],cantidad[i]);
            }

            //IMPRIMO LAS TEMPERAS DESDE LA SOBRECARGA DE OPERADOR EN LA CLASE TEMPERA
            //foreach (Tempera t in temperaArray)
            //{
            //     Console.WriteLine(t);
            //}

            //SUMO 2 TEMPERAS A TRAVEZ DE LA SOBRECARGA DE OPERADOR DE LA CLASE TEMPERA
            //temperaArray[0] += temperaArray[2];

            //MUESTRO LA TEMPERA SUMADA
            //Console.WriteLine(temperaArray[0]);

            //GENERO 1 INSTANCIA DE LA CLASE PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            Paleta p1 = 3;

            //SUMO UNA TEMPERA A UNA PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            p1 += temperaArray[2];
            p1 += temperaArray[1];
            p1 += temperaArray[0];

            //GENERO UNA SEGUNDA INSTANCIA DE LA CLASE PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            Paleta p2 = 2;

            //SUMO UNA TEMPERA A UNA PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            p2 += temperaArray[1];
            p2 += temperaArray[2];

            //SUMO UNA PALETA A UNA PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            p1 += p2;

            //MUESTRO UNA PALETA MEDIANTE LA SOBRECARGA DE OPERADOR
            //Console.WriteLine((string)p1);

            //MODIFICO LOS ATRIBUTOS PRIVADOS DE LA CLASE TEMPERA MEDIANTE LAS PROPIEDADES DE LA CLASE
            temperaArray[0].Marca = "Parapente";
            string marcaCambiar = temperaArray[1].Marca;
            temperaArray[2].Marca = marcaCambiar;

            //MUESTRO LAS MODIFICACIONES
            Console.WriteLine(temperaArray[0]);
            Console.WriteLine(temperaArray[1]);
            Console.WriteLine(temperaArray[2]);

            //MODIFICO LOS ATRIBUTOS PRIVADOS DE LA CLASE TEMPERA MEDIANTE LAS PROPIEDADES DE LA CLASE
            temperaArray[0].Precio = 23;

            //MUESTRO LAS MODIFICACIONES
            Console.WriteLine(p1.cantidadColores + "\n");

            //MUESTRO LA TEMPERA UBICADA EN EL INDICE 0 DEL ARRAY DE TEMPERAS ALBERGADO EN LA PALETA P1 MEDIANTE LA PROPIEDAD PARA SOBRECARGAR EL INDEXADOR
            Console.WriteLine(p1[1]);


            Console.ReadLine();
        }
    }
}
