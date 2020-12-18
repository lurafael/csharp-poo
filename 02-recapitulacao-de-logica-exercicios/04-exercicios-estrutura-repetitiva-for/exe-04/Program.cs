using System;
using System.Globalization;

namespace exe_04 {
    class Program {
        static void Main(string[] args) {

            int necessaryRepetitions = int.Parse(Console.ReadLine());
            double result = 0;

            for(int i = 0; i < necessaryRepetitions; i++) {
                string[] data = Console.ReadLine().Split(' ');
                double a = double.Parse(data[0], CultureInfo.InvariantCulture);
                double b = double.Parse(data[1], CultureInfo.InvariantCulture);

                if(b == 0)
                    Console.WriteLine("divisao impossivel");
                else
                    result = a / b;

                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
