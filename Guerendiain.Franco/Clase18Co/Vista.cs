using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18Cl;
using System.IO;

namespace Clase18Co
{
    public class Vista :IGrafica
    {
        public void Main(Empleado e)
        {
            e.Mostrar(this);
        }

        public void MostrarEnGUI(string cadena)
        {
            Console.WriteLine(cadena);
        }


        public bool EscribirTxT(string path, Empleado e)
        {
            try
            {
                using (StreamWriter st = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "Empleado.txt"))
                {
                    st.WriteLine(e.ToString());
                }
                return true;
            }
            catch(Exception es)
            {
                Console.WriteLine(es.Message);
                return false;
            }
        }
    }
}
