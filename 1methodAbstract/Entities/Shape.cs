
using _1methodAbstract.Entities.Enums; 

namespace _1methodAbstract.Entities
{
    abstract class Shape    //Forma
    {
        public Color Color { get; private set; }

        public Shape(Color color)
        {
            this.Color = color;
        }

        public abstract double Area();
    }
}
