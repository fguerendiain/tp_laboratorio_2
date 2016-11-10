using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {

        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(archivo, true))
                {
                    file.WriteLine(datos);
                }
                return true;

            }
            catch (Excepciones.ArchivosException e)
            {
                throw e.InnerException;
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                }
                return true;
            }
            catch (Excepciones.ArchivosException e)
            {
                throw e.InnerException;
            }
        }
   }
}
