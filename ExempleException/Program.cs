using System;

namespace ExempleException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um valor da multiplicação: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite um valor 2 da multiplicação: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro foi difgitado outra tipo de dado");
                Console.ReadKey();
                throw;
            }
          

            


        }
    }
}
