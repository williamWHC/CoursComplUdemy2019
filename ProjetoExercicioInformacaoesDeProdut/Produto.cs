using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicioInformacaoesDeProdut
{
    class Produto
    {
        //Definindo o encapsulamento
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //Liberando os objeto a receber nenhum argumento
        public Produto()
        {
            Quantidade = 10;
        }

        //Constrtutor que vai forçar o usuario ou programador a dar dados de entrada no objeto
        public Produto(string nome, double preco, int quantidade) //:this(nome, preco)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        //Construto d Teste
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
             this.Preco = preco;

        }



        //PropertiesNome
        public string Nome
        {
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                 } }
        }

     
        //Inserir dados no estoque
        public double AddEstoque(int quantidade)
        {
            return Quantidade += quantidade;
        }


        //Deleta produto do estoque
        public double RemoveEstoque(int quantidade)
        {
            return Quantidade -= quantidade;
        }


        //Soma da quantidade em estoque com o valor
        public double ValorEmEstoque()
        {
            return Quantidade * Preco;

        }


        public override string ToString()
        {
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " : Quantidade, Valor Total: " + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
