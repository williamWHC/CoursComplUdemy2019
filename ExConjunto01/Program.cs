using System;
using System.Collections.Generic;

namespace ExConjunto01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto
            //intanciando um conjunto
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            //Adciona elemnto dentro do conjunto
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //remove elemento
            // B.Remove(3);

            //Retira a diferença de A em B
            //A.ExceptWith(B);

            //Uni o elementos de B ao A
            //A.UnionWith(B);

            //Mostra apenas os numeros repetidos dos conjuntos
            //A.IntersectWith(B);

            //Percore os conjuntos
            //para cada int x dentro do conjunto A 
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            //Verificar se um numero digitado pertence 
            Console.WriteLine("Digite um numero: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine("Contem o numero " + N);
            }
            else
            {
                Console.WriteLine("Não contem o Numero " + N);
            }


            Console.ReadKey();
        }
    }
}
