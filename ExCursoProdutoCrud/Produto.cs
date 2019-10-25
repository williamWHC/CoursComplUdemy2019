using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCursoProdutoCrud
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

    
        //Construtor - definindo os paramentros de entrada 
       public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga com quantidade já pré definida
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ "
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", "
                        + Quantidade
                        + " unidades, Total: $ "
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoveProdutos(int removequantidade)
        {
            Quantidade -= removequantidade;
        }
    }
}
