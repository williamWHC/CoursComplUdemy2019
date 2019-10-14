using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //criando a chamada para a função
            double resultado = Maior(n1, n2, n3); //recebendo dados de entrada

            Console.WriteLine(" Maio = " + resultado);

            Console.ReadKey();
        }

        //chamada da função
        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }


    }
}
