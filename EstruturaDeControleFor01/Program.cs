using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeControleFor01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                
                Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;


            }

            Console.WriteLine("Total : " + soma);

            Console.ReadKey();
        }
    }
}
