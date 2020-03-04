using System;
using _1methodAbstract.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace _1methodAbstract.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;   //PI * RAIO AO QUADRADO para saber a cicuferencia.
        }
    }
}

