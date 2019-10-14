using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDadosPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double th = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   
            //Saida
            Console.WriteLine("Saida de Dados: ");

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(th.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("==========================================");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.WriteLine($"{vet[0]} {vet[1]} {vet[2]} {vet[3]}");



            Console.ReadKey();
        }
    }
}
