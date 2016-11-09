using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    class Gimnasio
    {
        #region ---------------ATRIBBUTOS--------------
        private List<Alumno> _alumnos;
        private List<Instructor> _instructor;
        private List<Jornada> _jornada;
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
            _alumnos = new List<Alumno>();
            _instructor = new List<Instructor>();
            _jornada = new List<Jornada>();
        }
        
        #endregion

        #region -----------------METODOS---------------
        public static bool Guardar()
        {
            return true;
        }

        public static bool Leer()
        {
            return true;
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

        #endregion

    }
}
