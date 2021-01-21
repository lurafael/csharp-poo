using System;
using Worker.Entities;
using Worker.Entities.Enums;

namespace Trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department department = new Department { Name = departmentName };
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int howManyContracts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= howManyContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract
                {
                    Date = date,
                    ValuePerHour = valuePerHour,
                    Hours = hours
                };
                
                
            }
        }
    }
}
