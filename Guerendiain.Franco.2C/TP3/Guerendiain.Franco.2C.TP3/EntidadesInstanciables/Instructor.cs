using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    [Serializable]
    public sealed class Instructor : PersonaGimnasio
    {
        #region ---------------ATRIBBUTOS--------------
        public Queue<Gimnasio.EClases> _clasesDelDia;
        public static Random _random;

        #endregion

        #region --------------CONSTRUCTORES------------
        public Instructor()
        {
        }

        static Instructor()
        {
            Instructor._random = new Random();
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>(); 
            this._clasesDelDia.Enqueue(_randomClases());
            this._clasesDelDia.Enqueue(_randomClases());
        }

        #endregion

        #region -----------------METODOS---------------
        protected override string ParticiparEnClase()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("CLASE DEL DIA ");
            foreach (Gimnasio.EClases t in this._clasesDelDia)
            {
                cadena.AppendLine(t.ToString());
            }

            return cadena.ToString();
        }

        public Gimnasio.EClases _randomClases()
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
            foreach (Gimnasio.EClases t in i._clasesDelDia)
            {
                if (t == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i==clase);
        }

        #endregion

    }
}
