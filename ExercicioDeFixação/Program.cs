using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeFixação
{
    class Program
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char gerenro = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            //Saida

            Console.WriteLine("Produto: ");
            Console.WriteLine($"{produto1} cujo preço é {preco1:F2}");
            Console.WriteLine($"{produto2} cujo preço é {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro : {idade} anos de idade, código {codigo} e gênero: {gerenro}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {preco3:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {preco3:F3}");
            Console.WriteLine("Separado decimal invariant culture: " + preco3.ToString("F3", CultureInfo.InvariantCulture ));

            Console.ReadKey();
        }
    }
}
