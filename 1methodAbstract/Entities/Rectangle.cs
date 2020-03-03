using System;
using System.Collections.Generic;
using System.Text;
using _1methodAbstract.Entities.Enums;
namespace _1methodAbstract.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) :base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
