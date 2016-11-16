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

        private string filePath;


        public Texto(string archivo)
        {
            this.filePath = archivo;
        }

        public bool guardar(string datos)
        {
            using (StreamWriter file = new StreamWriter(this.filePath, true))
            {
                file.WriteLine(datos);
            }
            return true;
        }

        public bool leer(out List<string> lines)
        {
            lines = new List<string>();
            
            using (StreamReader file = new StreamReader(this.filePath))
            {
                while(!file.EndOfStream){
                    lines.Add(file.ReadLine());
                }
            }

            return true;
        }
    }
}
