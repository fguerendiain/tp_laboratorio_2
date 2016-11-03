using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp) : base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            return this._precio * 1.28;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.23;
        }
    }
}
