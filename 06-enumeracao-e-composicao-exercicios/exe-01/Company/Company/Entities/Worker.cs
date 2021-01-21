using Company.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department Department { get; set; }

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;
            foreach(HourContract contract in Contracts)
                if(contract.Date.Year == year && contract.Date.Month == month)
                    income += contract.TotalValue();
            return income;
        }
    }
}
