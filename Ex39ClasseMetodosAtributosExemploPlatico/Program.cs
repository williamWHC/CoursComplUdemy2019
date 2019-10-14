using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex39ClasseMetodosAtributosExemploPlatico
{
    class Program
    {
        static void Main(string[] args)
        {
            // criando os objetos da class e o tipo de cada variavel(tipo Triangulo)
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores do Triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("===============================");

            Console.WriteLine("Digite os valores do Triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            //criar um variavel que recebe a AreaX do método area
            double areaX = x.Area();
            double areaY = y.Area();

            //mostrar na tela a area calcular
            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //colocar uma condição para saber que é o maior trangulo
            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área X");
            }
            else
            {
                Console.WriteLine("Maior Área Y");

                Console.ReadKey();
            }
        }
    }
}
