using System;
using System.Globalization;

namespace exe_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tax;

            if (salary <= 2000.00)
                tax = 0.00;
            else if (salary <= 3000.00)
                tax = (salary - 2000.00) * 0.08;
            else if (salary <= 4500.00)
                tax = (salary - 3000) * 0.18 + 1000.00 * 0.08;
            else
                tax = (salary - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000 * 0.08;

            if (tax == 0.00)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
