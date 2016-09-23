using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Camion:Vehiculo
    {
        float _tara;

        public Camion(float t, string pat, byte ruedas, EMarcas m):base(pat,ruedas,m)
        {
            this._tara = t;
        }

        public string MostrarCamion()
        {
            return base.Mostrar()+" TARA: "+this._tara;
        }
    }
}
