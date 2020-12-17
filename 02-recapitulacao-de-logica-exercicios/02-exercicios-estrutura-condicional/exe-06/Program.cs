using System;
using System.Globalization;

namespace exe_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (value > 100.0 || value < 0.00)
                Console.WriteLine("Fora de intervalo");
            else if (value <= 25.00)
                Console.WriteLine("Intervalo [0, 25]");
            else if (value <= 50.00)
                Console.WriteLine("Intervalo [25, 50]");
            else if (value <= 75.00)
                Console.WriteLine("Intervalo [50, 75]");
            else
                Console.WriteLine("Intervalo [75, 100]");
        }
    }
}
