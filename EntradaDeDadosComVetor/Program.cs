using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDadosComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Digite três cores na mesma linha");
           

            string[] vetx = Console.ReadLine().Split(' ');

            string a = vetx[0]; 
            string b = vetx[1];
            string c = vetx[2];

            Console.WriteLine(a + " " + b + " " + c );
       

            Console.ReadKey();


        }
    }
}
