using System;
using System.Collections.Generic;
using System.Text;
using ExWorker.Entities.Enums;

namespace ExWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public double SalaryBase { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //Builder
        public Worker()
        {

        }

        public Worker(string name, double salarybase, WorkerLevel level, Department department)
        {
            Name = name;
            SalaryBase = salarybase;
            Level = level;
            Department = department;
        }

        //Custom Methods
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double InCome(int year, int month)
        {
            double sun = SalaryBase;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sun += contract.TotalValue();
                }

            }
            return sun;
        }

    }
}
