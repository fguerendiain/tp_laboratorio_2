using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Paleta
    {
        #region ATRIBUTOS

        private Tempera[] _colores;
        private sbyte _cantidadMaximaColores;

        #endregion 

        #region CONSTRUCTORES

        private Paleta(): this(4)
        {
        }

        private Paleta(sbyte maxColor)
        {
            this._colores = new Tempera[maxColor];
            this._cantidadMaximaColores = maxColor;
        }

        #endregion

        #region SOBRECARGA DE OPERADORES

        public static implicit operator Paleta(sbyte cant)
        {
            return new Paleta(cant);
        }

        public static explicit operator string(Paleta p1)
        {
            return Mostrar(p1);
        }

        //SI LA TEMPERA ESTA EN LA PALETA ES TRUE
        public static bool operator ==(Paleta p1, Tempera t1)
        {
            for (int i = 0 ; i < p1._cantidadMaximaColores ; i++)
            {
                if (null != p1._colores.GetValue(i) && p1._colores[i] == t1)
                {
                    return true;
                }
            }
            return false;
        }

        //SI LA TEMPERA NO ESTA EN LA PALETA ES TRUE
        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1==t1);
        }

        //SI LA TEMPERA NO ESTA EN LA PALETA LA AGREGA
        //SI ESTA SUMA LA CANTIDAD
        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            if (!t1.Equals(null))
            {
                if (p1 != t1)
                {
                    int emptyPlace = filledPlaces(p1);

                    if (emptyPlace < p1._cantidadMaximaColores)
                    {
                        p1._colores[emptyPlace] = t1;
                    }
                }
                else
                {
                    for (int i = 0; i < filledPlaces(p1); i++)
                    {
                        if (p1._colores[i] == t1)
                        {
                            p1._colores[i]+=t1;
                            break;
                        }
                    }  
                }
            }
            return p1;
        }

        // SI HAY DOS TEMPERAS IGUALES SUMA LAS CANTIDADES
        // NO SE REPITEN LAS TEMPERAS
        // SE ELIMINAN LOS NULL
        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta paletaAuxiliar = new Paleta((sbyte)(p1._cantidadMaximaColores + p2._cantidadMaximaColores));

            for (int i = 0; i < filledPlaces(p1); i++)
			{
                paletaAuxiliar += p1._colores[i];
            }

            for (int i = 0; i < filledPlaces(p2); i++)
            {
                paletaAuxiliar += p2._colores[i];
            }

            Paleta paletaReturn = new Paleta((sbyte)(filledPlaces(paletaAuxiliar)));

            for (int i = 0; i < paletaReturn._cantidadMaximaColores; i++)
            {
                paletaReturn += paletaAuxiliar._colores[i];
            }

            compactPalet(paletaReturn);

            return paletaReturn;
        }

        //SE ELIMINA LA TEMPERA y COMPACTA
        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            if (p1 == t1)
            {
                for (int i = 0; i < p1._cantidadMaximaColores; i++)
                {
                    if (p1._colores[i] == t1)
                    {
                        p1._colores[i] = null;
                        compactPalet(p1);
                        break;
                    }
                }
            }
            return p1;
        }



        #endregion

        #region METODOS

        //
        private static string Mostrar(Paleta p1)
        {
            string ret = "La cantidad de temperas es " + p1._cantidadMaximaColores + "\n\n";

            for (int i=0; i < filledPlaces(p1) ; i++)
            {
                ret += p1._colores[i] + "\n";
            }
            return ret;
        }

        //
        private static int filledPlaces(Paleta p1)
        {
            int firstNull = 0;
            for (int i = 0; i < p1._cantidadMaximaColores; i++)
            {
                if (null != p1._colores.GetValue(i))
                {
                    firstNull++;
                }
            }
            return firstNull;
        }

        //
        private static void compactPalet(Paleta p1)
        {
            int index = filledPlaces(p1);
            if (index < p1._cantidadMaximaColores)
            {
                for (int i = index; i < p1._cantidadMaximaColores-1; i++)
                {
                    p1._colores[i] = p1._colores[i + 1];
                }
            }
        }
        
        #endregion

        #region PROPIEDADES

        //Propiedad de solo lectura que retorna la cantidad de colores
        public int cantidadColores
        {
            get { return this._cantidadMaximaColores; }
            //set { this._cantidadMaximaColores = value; }
        }

        #endregion

        #region PROPIEDAD INDEXADOR

        public Tempera this[int indice]
        {
            //ME PERMITE RETORNAR UNA TEMPERA CARGANDO EL SUBINDICE DIRECTAMENTE SOBRE UN OBJETO TIPO PALETA
            get
            {
                if (indice > this._cantidadMaximaColores || indice < 0)
                    return null;
                else
                    return this._colores[indice];
            }

            //ME PERMITE CARGAR SETEAR VALORES A UNA INSTANCIA DE TEMPERA LLAMANDOLA DIRECTAMENTE DESDE EL OBJETO PALETA QUE CONTIENE SU ARRAY
            set
            {
                if (indice >= 0 && indice < this._cantidadMaximaColores)
                {
                    this._colores[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }

        #endregion

    }
}
