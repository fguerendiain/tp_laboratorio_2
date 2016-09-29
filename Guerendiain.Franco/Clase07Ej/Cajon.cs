using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07Ej
{
    class Cajon
    {
        #region ATRIBUTOS
        private List<Fruta> _frutas;
        private int _volumen;
        #endregion

        #region CONSTRUCTOR
        private Cajon()
        {
            _frutas = new List<Fruta>();
        }

        public Cajon(int volumen): this()
        {
            _volumen = volumen;
        }
        #endregion

        #region METODOS
        public int CalcularEspacioDisponible()
        {
            return _volumen - _frutas.Count;
        }

        public string MostrarContenido()
        {
            string cadena = "Cantidad de Frutas: " + _frutas.Count + "\nEspacio total del Cajon: " + _volumen + "\n\n";
            foreach (Fruta t in _frutas)
            {
                cadena += "\nFruta nº " + _frutas.IndexOf(t) + "\n\nCantidad: " + t.volumen + "\nPeso : " + t.peso + "\n---------------\n\n";             
            }

            return cadena;
        }

        public List<Fruta> AgregarFruta(Fruta nuevaFruta)
        {
            _frutas.Add(nuevaFruta);
            return _frutas;
        }

        public List<Fruta> QuitarFruta()
        {
            int rnd = new Random().Next(_frutas.Count);
            _frutas.Remove(_frutas.ElementAt(rnd));
            return _frutas;
        }
        #endregion
    }
}
