using Contributors.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contributors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            double totalTaxes = 0.00;

            Console.Write("Enter the number of tax payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char individualOrCompany = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (individualOrCompany == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(healthExpenditures, name, annualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(numberOfEmployees, name, annualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ " +
                    $"{taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");

                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
