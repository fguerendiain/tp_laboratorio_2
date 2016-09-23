using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Lavadero
    {

        #region ATRIBUTOS
        List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private double _totalAuto = 0;
        private double _totalCamion = 0;
        private double _totalMoto = 0;

        #endregion

        #region PROPIEDADES
        public List<Vehiculo> Lista
        {
            get{ return this._vehiculos;}
        }
        #endregion

        #region CONSTRUCTOR
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }
        #endregion

        #region METODOS
        public double MostrarTotalFacturado()
        {
            double total = MostrarTotalFacturado(EVehiculos.Auto);
            total += MostrarTotalFacturado(EVehiculos.Camion);
            total += MostrarTotalFacturado(EVehiculos.Moto);
            _totalAuto = 0;
            _totalCamion = 0;
            _totalMoto = 0;
            return total;
        }

        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            foreach (var v in this._vehiculos)
            {
                switch (tipo)
                {
                    case EVehiculos.Auto:
                        if(v is Auto) this._totalAuto += _precioAuto;
                        break;
                    case EVehiculos.Camion:
                        if (v is Camion) this._totalCamion += _precioCamion;
                        break;
                    case EVehiculos.Moto:
                        if (v is Moto) this._totalMoto += _precioMoto;
                        break;
                }
            }
            switch (tipo)
            {
                case EVehiculos.Auto:
                    return this._totalAuto;
                case EVehiculos.Camion:
                    return this._totalCamion;
                case EVehiculos.Moto:
                    return this._totalMoto;
            }
            return -1;
        }
  

/*        public double MostrarTotalFacturado(EVehiculos tipo)
        {            
            float precio;
            Predicate<Vehiculo> filter;
            switch(tipo)
            {
                case EVehiculos.Auto:
                    precio = this._precioAuto;
                    filter = delegate(Vehiculo v){
                        return v is Auto;
                    };
                    break;
                case EVehiculos.Camion:
                    precio = this._precioCamion;
                    filter = delegate(Vehiculo v){
                        return v is Camion;
                    };
                    break;
                default:
                    precio = this._precioMoto;
                    filter =  delegate(Vehiculo v){
                        return v is Moto;
                    };
                    break;
            }            

            return precio * this._vehiculos.FindAll(filter).Count;
        }*/

        public static int OrdenarPorPatente(Vehiculo v1, Vehiculo v2)
        {
            //si las patenmtes son iguales devolves 0, si patente 1 es mayor a patente 2 devolves 1, sino -1
            return v1.Patente.CompareTo(v2.Patente);
        }

        public static int OrdenarPorMarca(Vehiculo v1, Vehiculo v2)
        {
            //compara alfabeticamente las marcas de los vehiculos
            return string.Compare((v1.Marca.ToString()), (v2.Marca.ToString()), true);
        }

        #endregion

        #region SOBRECARGA DE OPERADORES
        public static bool operator ==(Lavadero l, Vehiculo v)
        {
            return l._vehiculos.Exists(delegate(Vehiculo itV) { return itV == v; });            
        }

        public static bool operator !=(Lavadero l, Vehiculo v)
        {
            return !(l==v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculo v)
        {
            if(l != v )
                l._vehiculos.Add(v);
            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculo v)
        {
            l._vehiculos.Remove(v);
            return l;
        }
        #endregion
    }
}
