using Figures.Entities.Enums;

namespace Figures.Entities
{
    class Rectangle : Shape //Ou deixo a classe Rectangle de forma abstrata, ou implemento o método área
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() //O método abstract não precisa do virtual pra usar o override
        {
            return Width * Height;
        }
    }
}
