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
        List<string> historial;

        private Texto()
        {
            historial = new List<string>();
        }

        public Texto(string archivo) :this()
        {
            historial.Add(archivo);
        }

        public bool guardar(string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(datos, true))
                {
                    file.WriteLine(datos);
                }
                return true;

            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public bool leer(out List<string> datos)
        {
            List<string> listaAux = new List<string>();

            try
            {
                if (this.historial == null)
                {
                    datos = null;
                    return false;
                }

                foreach (string t in this.historial)
                {
                    using (StreamReader file = new StreamReader(this.historial[0]))
                    {
                        listaAux[t.IndexOf(t)] = file.ReadToEnd();
                    }
                }
                datos = listaAux;
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
