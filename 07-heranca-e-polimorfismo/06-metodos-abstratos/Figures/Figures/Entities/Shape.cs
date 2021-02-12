using Figures.Entities.Enums;

namespace Figures.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //Como cada tipo de figura tem um cálculo diferente para área, usa-se o método abstrato
    }
}
