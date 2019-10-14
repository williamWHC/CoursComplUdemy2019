using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {         

            funcionario func1, func2;

            func1 = new funcionario();
            func2 = new funcionario();

            //Funcionario-1
            Console.Write("Qual o seu nome: ");
                func1.nome = Console.ReadLine();
            Console.Write("Qual a sua Salario : ");
                func1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("==========================");

            //funcionario-2
            Console.Write("Qual o seu nome: ");
                func2.nome = Console.ReadLine();
            Console.Write("Qual a sua Salario : ");
                func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Processamento
            double media = (func1.salario + func2.salario) / 2.0; 

            //Saida
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
