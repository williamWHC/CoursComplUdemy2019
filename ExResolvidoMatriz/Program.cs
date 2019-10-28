using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExResolvidoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Defini a quantidade de linhas e colunas
            int[,] mat = new int[n,n] ;

            //linhas
            for (int i = 0; i < n; i++)
			{
                //converte os dados na minhas linha para string
                string[] vet = Console.ReadLine().Split(' ');

                //Colunas
                for (int j = 0; j < n; j++)
			    {
                mat[i,j] = int.Parse(vet[j]);
			    }
			}

             Console.WriteLine("main diagonal: ");
            for (int i = 0; i < n; i++)
			{
                Console.Write(mat[i,i] + " ");
			}

            //numeros negativos
            int count = 0;
            for (int i = 0; i < n; i++)
			{
               for (int j = 0; j < n; j++)
			   {
                 
                 if (mat[i,j] < 0)
	             {
                        count++;
	             }   
			   }
			}

            Console.Write("Number Negative: " + count);
          

            Console.ReadKey();
        }
    }
}
