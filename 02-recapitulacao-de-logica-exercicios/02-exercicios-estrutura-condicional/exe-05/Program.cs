using System;
using System.Globalization;

namespace exe_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int code = int.Parse(data[0]);
            int quantity = int.Parse(data[1]);
            double result;

            if (code == 1)
                result = 4.00 * quantity;
            else if (code == 2)
                result = 4.50 * quantity;
            else if (code == 3)
                result = 5.00 * quantity;
            else if (code == 4)
                result = 2.00 * quantity;
            else
                result = 1.50 * quantity;

            Console.WriteLine("Total: R$" + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
