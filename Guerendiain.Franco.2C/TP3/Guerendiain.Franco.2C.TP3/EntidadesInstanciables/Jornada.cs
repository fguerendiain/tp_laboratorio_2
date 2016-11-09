using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    class Jornada
    {
        #region ---------------ATRIBBUTOS--------------
        private List<Alumno> _alumno;
        private Instructor.EClases _clase;
        private Instructor _instructor;
        #endregion

        #region --------------CONSTRUCTORES------------
        private Jornada()
        {
            _alumno = new List<Alumno>();
        }

        public Jornada(Instructor.EClases clase, Instructor instructor):this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion

        #region -----------------METODOS---------------
        public static bool Guardar(Jornada jornada)
        {
            return true;   
        }

        public static bool Leer(Jornada jornada)
        {
            return true;
        }

        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine(this._alumno.ToString());
            cadena.AppendLine(this._instructor.ToString());

            return cadena.ToString();
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j._alumno.Contains(a))
            {
                return j;
            }
            j._alumno.Add(a);
            return j;
        }
        
        public static bool operator ==(Jornada j, Alumno a)
        {
            return j._alumno.Contains(a); //si no le llega a gustar sobrecargo un == en la clase Alumno de alumno==alumno con el criterio de alumno == clase.
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        #endregion

    }
}
