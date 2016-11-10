using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public class Instructor : PersonaGimnasio
    {
        #region ---------------ATRIBBUTOS--------------
        protected Queue<EClases> _clasesDelDia;
        protected static Random _random;

        #endregion

        #region --------------CONSTRUCTORES------------
        static Instructor()
        {
            _random = new Random();
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            _clasesDelDia.Dequeue();
            _clasesDelDia.Dequeue();
        }

        #endregion

        #region -----------------METODOS---------------
        public override string ParticiparEnClase()
        {
            return "CLASE DEL DIA " + this._clasesDelDia;
        }

        protected void _randomClases()
        {
            _random.Next();
        }

        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        protected override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.MostrarDatos());
            cadena.AppendLine(this.ParticiparEnClase());

            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        public static bool operator ==(Instructor i, EClases clase)
        {
            return i._clasesDelDia.Contains(clase);
        }

        public static bool operator !=(Instructor i, EClases clase)
        {
            return !(i==clase);
        }

        #endregion

        #region ----------------ENUMERADOS-------------
        public enum EClases
        {
            Natacion,
            Pilates,
            CrossFit,
            Yoga
        }

        #endregion
    }
}
