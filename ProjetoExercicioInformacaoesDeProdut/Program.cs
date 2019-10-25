using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioInformacaoesDeProdut
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados


            //foi craiada variaveis auxiliares para receber os dados e depois enviar como parametros no contrutor
            Console.WriteLine("Digite os dados informados");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            */


            //instanciando o objeto e passado como parametros os dados contido nas variaveis
            Produto product = new Produto(nome, preco);

            Produto product2 = new Produto();

            /*3 Modo de instanciar o produto
            Produto product3 = new Produto { 
                Nome = "TV", 
                Preco = 500.00, 
                Quantidade = 20 
            };*/



            Console.WriteLine("Dados Atualizados: " + product);

            Console.WriteLine("=======================");


            //Adiciona ao Estoque 
            Console.WriteLine();
            Console.Write("Quantidade a ser inserida no Estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            product.AddEstoque(qtd);

            //Dados Atualizados
            Console.WriteLine("Dados atualizados: " + product);

            //Remove ao Estoque
            Console.WriteLine();
            Console.Write("Quantidade a ser Removida do Estoque: ");
            qtd = int.Parse(Console.ReadLine());
            product.RemoveEstoque(qtd);

            //Dados Atualizados
            Console.WriteLine("Dados atualizados: " + product);


            product.Nome = "T"; //Properties
            Console.WriteLine(product.Nome);
            Console.WriteLine(product.Preco);
            Console.WriteLine(product.Quantidade);


            Console.WriteLine("Dados atualizados: " + product);
            Console.ReadLine();
        }
    }
}
