using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    class Llamada
    {
        #region ATRIBUTOS
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region PROPIEDADES
        public float Duracion
        {
            get{return _duracion;}
        }

        public string NroDestino
        {
            get { return _nroDestino ; }
        }

        public string NroOrigen
        {
            get { return _nroOrigen;}
        }
        #endregion

        #region CONSTRUCTOR
        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
        #endregion

        #region METODOS
        public void Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Duracion: " + this.Duracion.ToString());
            cadena.AppendLine("Origen: " + this.NroOrigen);
            cadena.AppendLine("Destino: " + this.NroDestino);

            Console.WriteLine(cadena);
        }

        public static int OrdenPorDuracion(Llamada uno, Llamada dos)
        {
            if (uno.Duracion > dos.Duracion)
            {
                return 0;
            }
            else if(uno.Duracion < dos.Duracion)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        #endregion

    }
}
