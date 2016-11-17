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
        private Queue<Gimnasio.EClases> _clasesDelDia;
        private static Random _random;

        #endregion

        #region --------------CONSTRUCTORES------------

        static Instructor()
        {
            Instructor._random = new Random();
        }

        public Instructor()
        {
        }

        public Instructor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>(); 
            this._randomClases();
        }

        #endregion

        #region -----------------METODOS---------------
        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Asigna 2 clases en forma aleatorea al instructor
        /// </summary>
        public void _randomClases()
        {
            this._clasesDelDia.Enqueue((Gimnasio.EClases)Instructor._random.Next(3));
            this._clasesDelDia.Enqueue((Gimnasio.EClases)Instructor._random.Next(3));
        }

        #endregion

        #region ----------SOBRECARGA DE METODOS--------

        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(base.MostrarDatos());
            cadena.AppendLine(this.ParticiparEnClase());

            return cadena.ToString();
        }

        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        /// <summary>
        /// Retorna True si el instructor da la clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
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
