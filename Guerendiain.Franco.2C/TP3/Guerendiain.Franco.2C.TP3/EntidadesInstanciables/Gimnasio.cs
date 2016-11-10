using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace EntidadesInstanciables
{
    public class Gimnasio : IArchivo<Gimnasio>
    {
        #region ---------------ATRIBBUTOS--------------
        private List<Alumno> _alumnos;
        private List<Instructor> _instructor;
        private List<Jornada> _jornada;
        #endregion

        #region ---------------PROPIEDADES-------------
        private Jornada this[int i]
        {
            get { return this._jornada[i];}
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Gimnasio()
        {
            _alumnos = new List<Alumno>();
            _instructor = new List<Instructor>();
            _jornada = new List<Jornada>();
        }
        
        #endregion

        #region -----------------METODOS---------------
        public bool Guardar(string archivo, Gimnasio datos)
        {
            throw new NotImplementedException();
        }

        public bool Leer(string archivo, out Gimnasio datos)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        private static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder cadena = new StringBuilder();
            
            
            return "";
        }

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        public static bool operator==(Gimnasio g, Alumno a)
        {
            return (g._alumnos.Contains(a));
        }

        public static bool operator!=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        public static Instructor operator ==(Gimnasio g, Gimnasio.EClases clase)
        {
            foreach (Instructor t in g._instructor)
	        {
		        if(t == clase)
                {
                    return t;
                }
        	}

            throw new SinInstructorException();
        }

        public static Instructor operator !=(Gimnasio g, Gimnasio.EClases clase)
        {
            throw new SinInstructorException();
        }

        public static bool operator==(Gimnasio g, Instructor i)
        {
            return (g._instructor.Contains(i));
        }

        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g == i);
        }

        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (g!=a)
            {
                g._alumnos.Add(a);
            }
            
            return g;
        }

        public static Gimnasio operator +(Gimnasio g, Gimnasio.EClases clase)
        {
            g._jornada.Add(new Jornada(clase, (g == clase)));

            foreach (Alumno t in g._alumnos)
            {
                if (t == clase)
                {
                    g._jornada[0] += t;
                }

            }
            
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
