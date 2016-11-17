using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Entidades
{
    public sealed class Tienda: Local ,IArchivos<string>
    {
        #region ---------------ATRIBBUTOS--------------
        private string _nombre;
        #endregion

        #region --------------CONSTRUCTORES------------
        public Tienda(string nombre, int anchoDeFrente, string direccion):base(direccion,anchoDeFrente)
        {
            this._nombre = nombre;
        }
        #endregion

        #region ---------------PROPIEDADES-------------
        public override int AnchoDeFrente
        {
            get
            {
                return this._anchoDeFrente;
            }
            set
            {
                try
                {
                    if(ValidarAnchoDeFrente(value))
                    {
                        this._anchoDeFrente = value;
                    }
                }
                catch(AnchoFrenteInvalidoException e)
                {
                    throw e;
                }
            }
        }
        #endregion

        #region -----------------METODOS---------------
        /// <summary>
        /// Valida que el valor pasado como parametro sea par y no sea negativo
        /// </summary>
        /// <param name="frente"></param>
        /// <returns></returns>
        public static bool ValidarAnchoDeFrente(int frente)
        {
            if (frente < 0 || (frente % 2) != 0)
            {
                throw new AnchoFrenteInvalidoException();
            }

            return true;
        }

        /// <summary>
        /// Devuelve una cadena con los datos del objeto
        /// </summary>
        /// <param name="tienda"></param>
        /// <returns></returns>
        public static string ExponerDatos(Tienda tienda)
        {
            StringBuilder sBuilder = new StringBuilder();
            sBuilder.AppendLine("NOMBRE: " + tienda._nombre);
            sBuilder.AppendLine(tienda.ToString());
            sBuilder.AppendLine("<------------------------------->");
            return sBuilder.ToString();
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------

        /// <summary>
        /// Devuelve los datos de la clase padre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        /// <summary>
        /// Lee los datos de un archivo de texto y los guarda en una cadena
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo, true))
                {
                    datos = file.ReadToEnd();
                }
                return true;
            }
            catch
            {
                datos = "";
                throw new NoLeeException();
            }
        }

        /// <summary>
        /// Guarda los datos de una cadena pasada como parametro en un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo))
                {
                    file.WriteLine(datos);
                }
                return true;

            }
            catch
            {
                throw new NoGuardaException();
            }
        }
        #endregion
    }
}
