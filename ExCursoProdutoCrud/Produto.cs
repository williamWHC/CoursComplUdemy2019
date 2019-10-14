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
