using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCotacaoMoedaMenbroEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada da cotação
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Entrada da quantidade de dolar
            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Saida
            Console.Write("Valor a ser pago em reais = ");
            
        }
    }
}
