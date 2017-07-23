using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Inicio;

namespace Entidades.Punto10
{
    class Salon<T>
    {
        private List<T> _elementos;
        private int _capacidad;

        private Salon() { 
            this._elementos = new List<T>();
        
        }

        public Salon(int capacidadParam) : base() {

            this._capacidad = capacidadParam;
        }

        public static override void operator + (Salon<T> salonParam , T elementoParam){
            salonParam._elementos.Add(elementoParam);
        }

        public static override bool operator ==(Salon<T> salonParam, T elementoParam)
        {
            if (typeof(T) == typeof(Persona))
            {
                if (salonParam._capacidad > salonParam._elementos.Count)
                {
                    return true;
                }
                else{
                    throw new NoAgregaException("Capacidad completa.");
                }

            }
            else
            {
                throw new NoAgregaException("El elemento es del tipo " + typeof(T) + ". Se esperaba tipo Persona.");
            }

        }

        public static override bool operator !=(Salon<T> salonParam, T elementoParam)
        {
            return !(salonParam == elementoParam);
        }

    }

    class NoAgregaException : Exception{
        public NoAgregaException(string message){
            
        }    
    
    }


}
