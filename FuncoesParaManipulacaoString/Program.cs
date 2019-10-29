using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesParaManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "ABCD efgh IJ kefnaao    ";

            string novaString = original.ToUpper(); //ToUpper - deixa todas as string maiscula
            string novaString2 = original.ToLower(); //Deixa todas as string minusculas
            string novaString3 = original.Trim(); //retira todos os espaços
            int novaString4 = original.IndexOf("ef"); //mostra anumeração da posição da passagem de orgumento
            int novaString5 = original.LastIndexOf("ef"); //mostra o ultima posição da passagem de parametros
            string novaString6 = original.Substring(3);
            string novaString7 = original.Substring(3, 5);
            string novaString8 = original.Replace('a', 'x');//troca A por outro caracter X
            string novaString9 = original.Replace("abc", "xyz");
            //verifica se esta null ou vazia
            bool novaString10 = string.IsNullOrEmpty(original);
            //Tem null ou informações em branco
            bool novaStrin11 = string.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + novaString + "-");
            Console.WriteLine("ToLower: -" + novaString2 + "-");
            Console.WriteLine("Trim: -" + novaString3 + "-");
            Console.WriteLine("IndexOf('ef'): " + novaString4);
            Console.WriteLine("LastIndexOf('ef'): " + novaString5);
            Console.WriteLine("Substring(3): " + novaString6);
            Console.WriteLine("Substring(3, 5): " + novaString7);
            Console.WriteLine("Replacer: " + novaString8);
            Console.WriteLine("Replacer: " + novaString9);
            Console.WriteLine("IsNullOrEMmpty: " + novaString10);
            Console.WriteLine("IsNullOrWhiteSpace: " + novaString10);


            Console.ReadKey();
        }
    }
}
