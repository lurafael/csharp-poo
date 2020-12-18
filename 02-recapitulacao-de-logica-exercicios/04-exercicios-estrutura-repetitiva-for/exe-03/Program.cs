using System;
using System.Globalization;

namespace exe_03 {
    class Program {
        static void Main(string[] args) {
            
            int howManyTests = int.Parse(Console.ReadLine());

            for(int i = 0; i < howManyTests; i++) {
                string[] values = Console.ReadLine().Split(' ');
                double n1 = double.Parse(values[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(values[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(values[2], CultureInfo.InvariantCulture);

                double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
