using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{
    [Serializable]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Instructor))]
    public class Jornada
    {
        #region ---------------ATRIBBUTOS--------------
        public List<Alumno> _alumno;
        public Gimnasio.EClases _clase;
        public Instructor _instructor;
        #endregion

        #region --------------CONSTRUCTORES------------
        private Jornada()
        {
            this._alumno = new List<Alumno>();
        }

        public Jornada(Gimnasio.EClases clase, Instructor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }
        #endregion

        #region -----------------METODOS---------------

        /// <summary>
        /// Guarda los datos del objeto en un archivo txt
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada datos)
        {
            Texto export = new Texto();
            return export.Guardar("Jornada.txt", datos.ToString());
        }

        /// <summary>
        /// Devuelve una cadena con datos de ujornada obtenidos de un archivo txt
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static string Leer(Jornada datos)
        {
            Texto import = new Texto();
            string aux = "";
            import.Leer("Jornada.txt", out aux);
            return aux;
        
        }

        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("JORNADA: ");
            cadena.AppendLine("CLASE DE " + this._clase + " POR " + this._instructor);
            cadena.AppendLine("ALUMNOS:");
            foreach (Alumno t in this._alumno)
            {
                cadena.Append(t);
            }
            cadena.AppendLine("----------------------------------------------------------");
            return cadena.ToString();
        }
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------

        /// <summary>
        /// Agrega un Alumno a la Jornada, verificando que este no exista anteriormente
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j==a)
            {
                return j;
            }
            j._alumno.Add(a);
            return j;
        }
        
        /// <summary>
        /// Retorna True, si el Alumno ya existe en la Jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno t in j._alumno)
            {
                if (t == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        #endregion
    }
}
