using System;
using System.Globalization;

namespace Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            double A = double.Parse(data[0], CultureInfo.InvariantCulture);
            double B = double.Parse(data[1], CultureInfo.InvariantCulture);
            double C = double.Parse(data[2], CultureInfo.InvariantCulture);

            double triangle = A * C / 2.0;
            double circle = 3.14159 * C * C;
            double trapeze = (A + B) / 2.0 * C;
            double square = B * B;
            double retangle = A * B;

            Console.WriteLine("TRIANGULO: " + triangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangle.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
