using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
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
            get {return this.CalcularGanancia(TipoLlamada.Local;}
        }

        public float GananciaPorProvincial
        {
            get {return this.CalcularGanancia(TipoLlamada.Provincial;}
        }

        public float GananciaTotal
        {
            get {return this.CalcularGanancia(TipoLlamada.Todas;}
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

        public void Mostrar()
        {
            Console.WriteLine("Razon Social: " + this._razonSocial + "\n");

            foreach (Llamada t in _listaDeLlamadas)
            {
                if (t is Local)
                {
                    ((Local)t).Mostrar();
                }
                else
                {
                    ((Provincial)t).Mostrar();
                }
                
            }
        }

        public void OrdenarLlamadas()
        { 
        }
        #endregion
    }
}
