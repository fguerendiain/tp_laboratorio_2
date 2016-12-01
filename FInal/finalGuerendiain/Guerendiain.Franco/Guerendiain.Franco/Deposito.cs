using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guerendiain.Franco
{
    public class Deposito
    {
        //Ejercicio 3 --------------------------------------------------
        List<Producto> listaDeProductos;

        public Deposito()
        {
            listaDeProductos = new List<Producto>();
        }


        public static List<Producto> operator +(Deposito dep1, Deposito dep2)
        {
            foreach (Producto t in dep2)
    	    {
		        if(dep1.listaDeProductos.Contains(t))
                {
                    t.stock++;
                }
                else
                {
                    dep1.listaDeProductos.Add(t);
                }
	        }

            return dep1.listaDeProductos;
            //Ejercicio 3 --------------------------------------------------

        }

    
    }


}
