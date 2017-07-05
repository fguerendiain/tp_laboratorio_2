using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllNumeros;

namespace Clase11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ColectorDeNumeros cn = new ColectorDeNumeros(ETipoNumero.Par);

                Numero n1 = new Numero(Int32.Parse("23"));
                Numero n2 = new Numero(Int32.Parse("-56"));
                Numero n3 = new Numero(Int32.Parse("59"));
                Numero n4 = new Numero(Int32.Parse("-18"));
                Numero n5 = new Numero(Int32.Parse("0"));

                cn += n1;
                cn += n2;
                cn += n3;
                cn += n4;
                cn += n5;

                Console.WriteLine(cn);

                cn -= n3;
                cn -= n4;

                Console.WriteLine(cn);

                Console.ReadLine();

                Console.WriteLine(cn.SumaDeNumeros);
                Console.WriteLine(cn.RestaDeNumeros);
                Console.WriteLine(cn.MultiplicacionDeNumeros);
                Console.WriteLine(cn.DivisionDeNumeros);

                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("NUMEROS PAPA\n\n\n");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
            catch (OverflowException e)
            {
                Console.WriteLine("TE PASASTE MACHO\n\n\n");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("REVENTO Y NO TE LO ESPERABAS QUERIDO\n\n\n");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                //  throw e;
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("TODO PIOLA LOCO\n\n\n");
                Console.ReadLine();
            }


        }
    }
}
