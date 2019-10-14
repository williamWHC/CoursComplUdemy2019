using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39ClasseMetodosAtributosExemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //decobrir os lados do triangulo
            //
            Triangulo X, Y;

            //Objetos X & Y são istancias da Class Triangulo
            //referencia a class Triangulo as variceis X & Y// criando novas class com os atributos
             X = new Triangulo();
            Y = new Triangulo();

            //chama o objeto X com os atributos e istancia os valores aos atributos 
            Console.WriteLine("Entre com as medidas do triangulo X");
            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com as medidas do triangulo Y");
            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());

            double areaX = X.Area(); //recebe como retorno o valor raiz do método Area

            double areaY = Y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.ReadKey();
        }
    }
}
