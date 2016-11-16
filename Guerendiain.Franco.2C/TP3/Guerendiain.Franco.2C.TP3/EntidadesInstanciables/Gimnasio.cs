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
        public static bool Guardar(Gimnasio datos)
        {
            Xml<Gimnasio> export = new Xml<Gimnasio>();
            return export.Guardar("Gimnasio.xml", datos);
        }

        public static Gimnasio Leer(Gimnasio datos)
        {
            Xml<Gimnasio> import = new Xml<Gimnasio>();
            Gimnasio aux;
            import.Leer("Gimnasio.xml", out aux);
            return aux;
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        private static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder cadena = new StringBuilder();
            foreach (Jornada t in gim._jornada)
            {
                cadena.Append(t);
            }
            return cadena.ToString();
        }

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        public static bool operator==(Gimnasio g, Alumno a)
        {
            if(!object.ReferenceEquals(g, null))
            {
                return g._alumnos.Any(almUno => almUno == a);
            }
            return false;
        }

        public static bool operator!=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        public static Instructor operator ==(Gimnasio g, Gimnasio.EClases clase)
        {
            Instructor aux = g._instructor.FirstOrDefault(t => t == clase);

            if (!Object.Equals(aux, null))
            {
                return aux;
            }
            else
            {
                throw new Excepciones.SinInstructorException();
            }

        }

        public static Instructor operator !=(Gimnasio g, Gimnasio.EClases clase)
        {
            return g._instructor.FirstOrDefault(t => t != clase);
        }

        public static bool operator==(Gimnasio g, Instructor i)
        {
            if (!object.ReferenceEquals(g, null))
            {
                return g._instructor.Any(insUno => insUno == i);
            }
            return false;
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g == i);
        }

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
            Natacion,
            Pilates,
            CrossFit,
            Yoga
        }

        #endregion
    }
}
