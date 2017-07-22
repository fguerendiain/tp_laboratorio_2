using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Punto2F
{
    class ClaseConstructores
    {
        private string _soloLectura;
        private string _soloEscritura;

        public string SoloLectura{
            get{Console.WriteLine("Propiedad de solo Lectura");
            return _soloLectura;}
        }

        public string SoloEscritura{
           
            set { _soloEscritura = value; 
            Console.WriteLine("Propiedad de solo Escritura");}
        }


        public static ClaseConstructores() {
            Console.WriteLine("constructor estatico");
        }

        private ClaseConstructores(string param1, string param2) {
            Console.WriteLine(param1 + param2);
        }

        public ClaseConstructores()
            : this("constructor de ", "2 parametros")
        {
            Console.WriteLine("constructor Default");
            Console.WriteLine(SoloLectura);
            Console.WriteLine(SoloEscritura = "hola");
            this.MetodoDeInstancia();
            ClaseConstructores.Metododeclase();
        }

        public void MetodoDeInstancia() {
            Console.WriteLine("Metodo de Instancia");
        }

        public static void Metododeclase(){
            Console.WriteLine("Metodo de Clase");
        }


    }
}
