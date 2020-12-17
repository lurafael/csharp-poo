using System;
using System.Globalization;

namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            int workedHours = int.Parse(Console.ReadLine());
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = hourValue * workedHours;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
