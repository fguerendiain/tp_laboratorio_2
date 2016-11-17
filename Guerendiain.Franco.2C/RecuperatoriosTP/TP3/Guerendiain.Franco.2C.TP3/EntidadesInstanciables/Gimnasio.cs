using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{
    [Serializable]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Instructor))]
    [XmlInclude(typeof(Jornada))]
    public class Gimnasio
    {
        #region ---------------ATRIBBUTOS--------------
        public List<Alumno> _alumnos;
        public List<Instructor> _instructor;
        public List<Jornada> _jornada;
        #endregion

        #region ---------------PROPIEDADES-------------
        public Jornada this[int i]
        {
            get { return this._jornada[i];}
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructor = new List<Instructor>();
            this._jornada = new List<Jornada>();
        }
        
        #endregion

        #region -----------------METODOS---------------
        /// <summary>
        /// Guarda los datos del objeto en un archivo XML
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Guardar(Gimnasio datos)
        {
            Xml<Gimnasio> export = new Xml<Gimnasio>();
            return export.Guardar("Gimnasio.xml", datos);
        }

        /// <summary>
        /// Devuelve un objeto Gimnacio con datos obtenidos de un archivo XML
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static Gimnasio Leer(Gimnasio datos)
        {
            Xml<Gimnasio> import = new Xml<Gimnasio>();
            Gimnasio aux;
            import.Leer("Gimnasio.xml", out aux);
            return aux;
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        private static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder cadena = new StringBuilder();
            foreach (Jornada t in gim._jornada)
            {
                cadena.Append(t);
            }
            return cadena.ToString();
        }

        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        /// <summary>
        /// Devuelve true si el Alumno pertenece al gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator==(Gimnasio g, Alumno a)
        {
            foreach (Alumno t in g._alumnos)
            {
                if (t == a)
                    return true;
            }
            return false;
        }

        public static bool operator!=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Devuelve un instructor disponible para dar la clase, caso contrario retorna una Excepcion
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Instructor operator ==(Gimnasio g, Gimnasio.EClases clase)
        {
            foreach (Instructor t in g._instructor)
            {
                if (t == clase)
                {
                    if (!Object.Equals(t, null))
                        return t;
                }
            }
            throw new SinInstructorException();
        }

        /// <summary>
        /// Devuelve al primer Instructor encontrado que no da la clase indicada.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Instructor operator !=(Gimnasio g, Gimnasio.EClases clase)
        {
            foreach (Instructor t in g._instructor)
            {
                if (t != clase)
                {
                    return t;
                }
            }
            return null;
        
        }

        /// <summary>
        /// Retorna True si el instructor pertenece al gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator==(Gimnasio g, Instructor i)
        {
            foreach (Instructor t in g._instructor)
            {
                if (t == i)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Agrega un alumno al gimnasio verificando antes que no exista.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (g != a)
            {
                g._alumnos.Add(a);
            }
            else
            {
                throw new Excepciones.AlumnoRepetidoException();
            }
            
            return g;
        }

        /// <summary>
        /// Agrega una jornada al gimnasio setando un instructor y sus respectivos Alumnos
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, Gimnasio.EClases clase)
        {
            Jornada auxJornada = new Jornada(clase, (g == clase));

            foreach (Alumno t in g._alumnos)
            {
                if (t == clase)
                {
                    auxJornada._alumno.Add(t);
                }

            }
            g._jornada.Add(auxJornada);

            return g;
        }

        /// <summary>
        /// Agrega un instructor al gimnasio verificando antes que no exista.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            if (g != i)
            {
                g._instructor.Add(i);
            }
            return g;
        }

        #endregion

        #region ----------------ENUMERADOS-------------
        public enum EClases
        {
            Natacion = 0,
            Pilates = 1,
            CrossFit = 2,
            Yoga = 3
        }

        #endregion
    }
}
