using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01IdadePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa usuario1, usuario2;

            usuario1 = new Pessoa();
            usuario2 = new Pessoa();

            //Usuario1
            Console.Write("Qual o seu nome: ");
                usuario1.nome = Console.ReadLine();
            Console.Write("Qual a sua idade: ");
                usuario1.idade = int.Parse(Console.ReadLine());

            //Usuario2
            Console.Write("Qual o seu nome: ");
                usuario2.nome = Console.ReadLine();
            Console.Write("Qual a sua idade:");
                usuario2.idade = int.Parse(Console.ReadLine());

            if (usuario1.idade > usuario2.idade)
            {
                Console.WriteLine("Pessoal mais velha: " + usuario1.nome);
            }
            else
            {
                Console.WriteLine("pesssoal mais velha " + usuario2.nome);
            }

            Console.ReadKey();

        }
    }
}
