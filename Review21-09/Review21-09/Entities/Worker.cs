using Review21_09.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review21_09.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Contract> Contracts { get; set; } = new();

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

        public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContracts(Contract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (Contract obj in Contracts)
            {
                if (obj.Date.Month == month && obj.Date.Year == year)
                {
                    sum += obj.TotalValue();
                }
            }
            return sum;
        }

        public override string? ToString()
        {
            return
                $"Name: {Name}\nDepartment: {Department.Name}\n";
        }
    }
}
