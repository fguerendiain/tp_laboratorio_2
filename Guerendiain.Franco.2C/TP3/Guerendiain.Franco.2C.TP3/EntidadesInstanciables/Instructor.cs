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
        protected Queue<Gimnasio.EClases> _clasesDelDia;
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
            _clasesDelDia = new Queue<Gimnasio.EClases>();
            _clasesDelDia.Enqueue(_randomClases());
            _clasesDelDia.Enqueue(_randomClases());
        }

        #endregion

        #region -----------------METODOS---------------
        public override string ParticiparEnClase()
        {
            return "CLASE DEL DIA " + this._clasesDelDia;
        }

        protected Gimnasio.EClases _randomClases()
        {
            Array enumValues;
            enumValues = Enum.GetValues(typeof(Gimnasio.EClases));
            return (Gimnasio.EClases)enumValues.GetValue(_random.Next(enumValues.Length));
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
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            return i._clasesDelDia.Contains(clase);
        }

        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i==clase);
        }

        #endregion

    }
}
