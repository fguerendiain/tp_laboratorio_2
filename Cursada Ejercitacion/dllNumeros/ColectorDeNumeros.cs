using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllNumeros
{
    public class ColectorDeNumeros
    {
        protected List<Numero> _numeros;

        public ETipoNumero TipoNro
        {
            get;
            set;
        }

        //obtener la suma del primer numero contra todos los numeros
        public int SumaDeNumeros
        {
            get { return (int)ObtenerResultado(this, ETipoResultado.Suma); }
        }

        private static int SumaPri(ColectorDeNumeros colector)
        {
            int total = 0;
            for (int i = 1; i < colector._numeros.Count; i++)
            {
                total += colector._numeros[i] + colector._numeros[0];
            }
            return total;
        }

        //obtener la resta del primer numero contra todos los numeros
        public int RestaDeNumeros
        {
            get { return (int)ObtenerResultado (this,ETipoResultado.Resta); }
        }

        private static int RestaPri(ColectorDeNumeros colector)
        {
            int total = 0;
            for (int i = 1; i < colector._numeros.Count; i++)
            {
                total -= colector._numeros[i] - colector._numeros[0];
            }
            return total;
        }

        //obtener la multiplicacion del primer numero contra todos los numeros
        public int MultiplicacionDeNumeros
        {
            get { return (int)ObtenerResultado(this, ETipoResultado.Multiplicacion); }
        }

        public static int MultiPri(ColectorDeNumeros colector)
        {
            int total = 0;
            for (int i = 1; i < colector._numeros.Count; i++)
            {
                total *= colector._numeros[i] * colector._numeros[0];
            }
            return total;
        }

        //obtener la division del primer numero contra todos los numeros
        public double DivisionDeNumeros
        {
            get { return ObtenerResultado(this, ETipoResultado.Multiplicacion); }
        }

        public static double DiviPri(ColectorDeNumeros colector)
        {
            double total = 0;
            for (int i = 1; i < colector._numeros.Count; i++)
            {
                if (colector._numeros[i].PNumero != 0)
                    total /= colector._numeros[0] / colector._numeros[i];
            }
            return total;
        }
        
        private ColectorDeNumeros()
        {
                this._numeros = new List<Numero>();
        }

        public ColectorDeNumeros(ETipoNumero tipoNro):this()
        {
        }        
        
        public static ColectorDeNumeros operator +(ColectorDeNumeros colector, Numero nro)  
        {
            colector._numeros.Add(nro);
            return colector;
        }

        public static ColectorDeNumeros operator -(ColectorDeNumeros colector, Numero nro)
        {
            colector._numeros.Remove(nro);
            return colector;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            foreach (var t  in this._numeros)
            {
                cadena.AppendLine("Numero: " + t.PNumero.ToString());
            }

            return cadena.ToString();
        }

        protected static double ObtenerResultado(ColectorDeNumeros colector, ETipoResultado tipo)
        {
            switch (tipo)
            { 
                case ETipoResultado.Suma:
                    return SumaPri(colector);
                case ETipoResultado.Resta:
                    return RestaPri(colector);
                case ETipoResultado.Multiplicacion:
                    return MultiPri(colector);
                case ETipoResultado.Division:
                    return DiviPri(colector);
            }
            return 0;
        }

    }
}

