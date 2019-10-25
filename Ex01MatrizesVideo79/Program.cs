using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01MatrizesVideo79
{
    class Program
    {
        static void Main(string[] args)
        {
            //[,] = matriz bidimencional 
            //definir o tipo da matriz, nome, e quantidade de linhas e colunas.
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //Lenght (Comprimento) - quantos elementos a matriz tem no total
            Console.WriteLine(mat.Rank); //Rank (Classificação) - quantas linhas tem na matriz 
            Console.WriteLine(mat.GetLength(0)); //GetLenght(Obtem/Comprimento) - obtem a quandidade de comprimento dos elemetos linhas
            Console.WriteLine(mat.GetLength(1)); //passando o 1 como argumento ele obtem a quantidade de elemento em Colunas
            Console.ReadKey();


        }
    }
}
