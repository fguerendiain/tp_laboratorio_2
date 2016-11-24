using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseUltima;

namespace ClaseUltimaConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            Moneda mon = new Moneda();

            mon.Ganar += new DelMonedaWins(Ganamos);
            mon.Perder += new DelMonedaLose(p.Perdimos);
            mon.Tirar(ELado.Cara);

        }

        private static void Ganamos()
        {
            Console.WriteLine("Ganamos");
            Console.ReadLine();
        }

        public void Perdimos(ELado lado)
        {
            Console.WriteLine("Perdimos, te salio " + lado);
            Console.ReadLine();
        }

        
    
    }
}
