using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    public abstract class Llamada
    {
        #region ATRIBUTOS
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region PROPIEDADES
        public abstract float CostoLlamada {get;}

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
        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Duracion: " + this.Duracion.ToString());
            cadena.AppendLine("Origen: " + this.NroOrigen);
            cadena.Append("Destino: " + this.NroDestino);

            return cadena.ToString();
        }

        public static int OrdenPorDuracion(Llamada uno, Llamada dos)
        {
            if (uno.Duracion > dos.Duracion)
            {
                return 1;
            }
            else if(uno.Duracion < dos.Duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            return ((llamadaUno.Equals(llamadaUno)) && (llamadaDos.Equals(llamadaDos)) && (llamadaUno.NroOrigen == llamadaDos.NroOrigen) && (llamadaUno.NroDestino == llamadaDos.NroDestino));
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }
        
        #endregion
    }
}
