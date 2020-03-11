using System;

namespace ExempleException
{
    class Program
    {
        static void Main(string[] args)
        {

            //Com o tratamento de expection passando como paramento no catch a exception DivideByZeroException
            //O proprio usuario pode definir a mensagem de erro, substituindo no ConseleAplication.
            try
            {
                Console.Write("Digite um valor da multiplicação: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite um valor 2 da multiplicação: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro de multiplicação !!");
                throw;
            }
            

            //O tratamento de Exception por formatexception você pode apenas definir a mensagem
            //Com o função (Message) para apenas mostrar para o usuario a mensagem de erro. 
            /*
            try
            {
                Console.Write("Digite um valor da multiplicação: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite um valor 2 da multiplicação: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Mensagem de Erro -> " + e.Message);
                throw;
            }
            */
            
          

            


        }
    }
}
