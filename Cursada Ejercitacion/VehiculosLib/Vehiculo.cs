using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Vehiculo
    {

        #region ATRIBUTOS
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        #endregion

        #region PROPIEDADES
        public string Patente
        {
            get{ return this._patente;}            
        }

        public EMarcas Marca
        {
            get { return this._marca; }
        }
        #endregion

        #region CONSTRUCTOR
        public Vehiculo(string pat, byte ruedas, EMarcas m)
        {
            this._patente = pat;
            this._cantRuedas = ruedas;
            this._marca = m;
        }
        #endregion

        #region METODOS
        protected string Mostrar()
        {
            return "PATENTE: " + this._patente + " Ruedas: " + this._cantRuedas + " Marca: " + this._marca + "\n";
        }

        public void AcelerarHasta(byte vel)
        {
            Console.WriteLine("Acelerado hasta: "+vel);
        }


        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1._patente == v2._patente && v1._marca == v2._marca;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion

    }
}
