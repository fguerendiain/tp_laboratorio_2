using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Entidades.Punto7
{
    class Burbujeo
    {

        public void BurbujeoMetodoInstancia() {
            try
            {
                throw new MiExcepcion();
            }
            catch (MiExcepcion e)
            {
                Guardar(e.InnerException.TargetSite + " " + e.InnerException.Data);
                BurbujeoMetodoEstatico();
            }

        }


        public static void BurbujeoMetodoEstatico(){
            try{
                throw new MiExcepcion();
            }
            catch(MiExcepcion e){
                Guardar(e.InnerException.TargetSite + " " + e.InnerException.Data);
            }
        
        }


        public static bool Guardar(string datos)
        {
            try
            {
                using (StreamWriter file = new StreamWriter("burbujeo.txt", true))
                {
                    file.WriteLine(datos);
                }
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


    }
}
