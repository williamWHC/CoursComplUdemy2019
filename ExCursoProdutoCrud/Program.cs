using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCursoProdutoCrud
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada do Nome
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            //Entrada do Preço
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Quantidade
            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //instanciar a class produto
            Produto product = new Produto(nome, preco, quantidade);



            //Primeira saida da Tela
            Console.WriteLine($"Dados do produto: {product}");
            Console.WriteLine("===============================");

            //Entrada de produto no estoque
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            product.AdicionarProdutos(qtd);

            //nova saida com os dados atualizados de entrada
            Console.WriteLine("Dados atualizados: " + product);
            Console.WriteLine("===============================");

            //Remover quantidade
            Console.Write("Digite o número de produtos a ser retirado do estoque: ");
            int rqtd = int.Parse(Console.ReadLine());
            product.RemoveProdutos(rqtd);

            Console.WriteLine("Dados atualizados: " + product);

            Console.ReadKey();
        }
    }
}
