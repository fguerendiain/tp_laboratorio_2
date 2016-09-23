using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculosLib
{
    public class Moto:Vehiculo
    {
        float _cilindrada;

        public Moto(float cil, string pat, byte ruedas, EMarcas m):base(pat,ruedas,m)
        {
            this._cilindrada = cil;
        }

        public string MostrarMoto()
        {
            return base.Mostrar()+" Cilindrada: "+this._cilindrada;
        }
    }
}
