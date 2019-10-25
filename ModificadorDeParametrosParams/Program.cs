using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParametrosParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado1 = Calculator.Sun(10, 20, 30, 40 );
            Console.WriteLine("Soma: " + resultado1);

            int resultado2 = Calculator.Sun( 5, 3, 6 );
            Console.WriteLine("Soma: " + resultado2);

            Console.ReadKey();
        }
    }
}
