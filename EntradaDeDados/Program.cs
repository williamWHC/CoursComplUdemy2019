using System;

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados

            char genero = 'F';
            int idade = 28;
            double saldo = 25.3651;
            string nome = "william";
  
            Console.WriteLine("Olá meu nome eh {0} e tenho {1} , com saldo atual de R$: {2:F2} reais", CultureInfo.InvariantCulture ,nome ,idade, saldo); //IFormatProvider = CultureInfo.InvariantCulture

            Console.WriteLine($"Meu nome eh {nome} e tenho {idade}, atualmente tenho em conta o valor de {saldo:F2} reais");

            Console.ReadKey();



        }
    }
}
