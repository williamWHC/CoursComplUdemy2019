using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeAtribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;
            //Saida a:11 b = 11

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            int c = 10;
            int d = ++c;

            Console.WriteLine("------------------");

            Console.WriteLine("a: " + c);
            Console.WriteLine("b: " + d);
            //Saida c: 11 d:11



            Console.ReadKey();
        }
    }
}
