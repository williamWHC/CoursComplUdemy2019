using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticaoWhile01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada de dados
            //pedir pro usuario digitar
            Console.Write("Digite um número: ");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Enquanto que o valo digitado for maio que 0, ele vai entrar no bloco de controle 
            while (N >= 0.0)
            {

                //Calcular a Raiz Quadrada e imprime da tela
                double raiz = Math.Sqrt(N);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                //depois pedi pro suario digitar outro valor
                Console.Write("Digite outro número: ");
                N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            Console.WriteLine("Número Invalido");

            Console.ReadLine();
       
        }
    }
}
