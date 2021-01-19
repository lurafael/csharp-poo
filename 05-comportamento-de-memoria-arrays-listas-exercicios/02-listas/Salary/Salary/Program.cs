using System;
using System.Collections.Generic;
using System.Globalization;

namespace Salary {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int howManyEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= howManyEmployees; i++) {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            double searchId = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Employee emp = employees.Find(employee => employee.Id == searchId);

            if(emp != null) {
                Console.Write("Enter the percentage: ");
                double tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.IncreaseSalary(tax);
            }
            else
                Console.WriteLine("This id does not exist!");

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach(Employee employee in employees) {
                Console.WriteLine(employee);
            }
        }
    }
}
