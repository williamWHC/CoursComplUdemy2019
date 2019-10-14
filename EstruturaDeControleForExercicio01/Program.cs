using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeControleForExercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio

            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i < X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
