using System;
using Curse3Composition.Entities;
using Curse3Composition.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Curse3Composition.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public LevelWorker Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, LevelWorker level, double basesalary, Department department)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = basesalary;
            this.Department = department;
        }

        public void AddContrac(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void RemoveContrac(HourContract contract)
        {
            Contract.Remove(contract);
        }

        //Query para saber a enda do trabalhador
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValuesr();
                }
            }
            return sum;
        } 

    }
}
