using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresDeTipoReferenciaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada De Dados - definindo a quantidadade de alocamentos
            Console.Write("Qual a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            //criando um vetor de referencia de Classe Product
            Product[] vet = new Product[n];

            //criando um for para percorrer os blocos dos vetores
            //a cada bloco ele vai acrecentar no vetor de tipo Class os Name & Price
            //chama o vetor em cada posição e adciona os dados de entrada em cada atributos
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o Nome do Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Preço do Produto");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = nome, Price = preco };
            }

            //buscando a métia dos Preços dos de cada vetor
            //percore todas os preços e atribui os valores na variavel soma
            // soma vai receber ela mesmo mais o apontamento de onde esta o valor, vai percorrer cada vetor e pega os valores de cada preço e soma com a variavel soma
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vet[i].Price;
            }

            //pega todos os valores obtidos e divite pela quantidade de foi definida de produtos
            double avg = soma / n;

            //Saida
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
