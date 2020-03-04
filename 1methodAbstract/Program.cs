using System;
using System.Globalization;
using System.Collections.Generic;
using _1methodAbstract.Entities;
using _1methodAbstract.Entities.Enums;

namespace _1methodAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();   //sempre cirar com o tipo generico
            
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape {i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else if (type == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.WriteLine("Error, character invalid");
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("f2"), CultureInfo.InvariantCulture);
            }
            Console.ReadKey();
        }
    }
}
