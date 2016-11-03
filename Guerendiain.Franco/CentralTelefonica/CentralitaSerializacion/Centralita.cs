using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class Centralita
    {
        #region ATRIBUTOS
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        #region PROPIEDADES
        public float GananciaPorLocal
        {
            get {return this.CalcularGanancia(TipoLlamada.Local);}
        }

        public float GananciaPorProvincial
        {
            get {return this.CalcularGanancia(TipoLlamada.Provincial);}
        }

        public float GananciaTotal
        {
            get {return this.CalcularGanancia(TipoLlamada.Todas);}
        }

        public List<Llamada> Llamadas
        {
            get {return _listaDeLlamadas;}
        }
        #endregion

        #region CONSTRUCTORES
        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Calcula la ganancia de acuerdo al tipo de llamada
        /// </summary>
        /// <param name="tipo">Define el concepto a filtrar</param>
        /// <returns>Devuelve la ganancia de acuerdo al filtro</returns>
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float costo = 0;
            
            switch(tipo)
            {   
                case TipoLlamada.Local:
                    foreach (Llamada t in _listaDeLlamadas)
                    {
                        if (t is Local)
                        {
                            costo += ((Local)t).CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada t in _listaDeLlamadas)
                    {
                        if (t is Provincial)
                        {
                            costo += ((Provincial)t).CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    costo = this.GananciaPorLocal + this.GananciaPorProvincial;
                    break;
            }

            return  costo;
            
        }

        /// <summary>
        /// Muestra Todas las llamadas contenidas en una instancia de Centralita
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine("------------------------------\n" + "Razon Social: " + this._razonSocial + "\n");

            foreach (Llamada t in this.Llamadas)
            {
                Console.WriteLine(t.ToString());
            }

            //foreach (Llamada t in _listaDeLlamadas)
            //{
            //    if (t is Local)
            //    {
            //        ((Local)t).Mostrar();
            //    }
            //    else
            //    {
            //        ((Provincial)t).Mostrar();
            //    }
                
            //}
        }

        /// <summary>
        /// Ordena las llamadas por Duracion de menor a mayor
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenPorDuracion);
        }

        /// <summary>
        /// Recibe una llamada y la agrega a la coleccion
        /// </summary>
        /// <param name="llamadaForAdd">Instancia de Llamada a agregar</param>
        private void AgregarLlamada(Llamada llamadaForAdd)
        {
            this.Llamadas.Add(llamadaForAdd);
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Centralita central, Llamada llamadaUno)
        {
            foreach (Llamada t in central.Llamadas)
            {
                if (t == llamadaUno)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamadaUno)
        {
            return !(central == llamadaUno);
        }

        public static Centralita operator +(Centralita central, Llamada llamadaUno)
        {
            if (central != llamadaUno)
            {
                central.AgregarLlamada(llamadaUno);
                return central;
            }
            else
            {
                Console.WriteLine("\n\nLa Llamada ya existe en este listado\n\n");
                return central;
            }

        }
        #endregion
    }
}
