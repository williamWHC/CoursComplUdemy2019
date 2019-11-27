using System;
using Composicao.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //Class department associada a class department--V
        public Department Department { get; set; }
        //Associando com a Class HourContract
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();           //instanciar a lista para garantir que ela não seja nulla(null)


        //Construtor da Class
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double basesalary, Department department) //Não incluir associações para muitos, por exemplo propriedade Contracts
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
            Department = department;
        }

        //metodos
        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }

        //Saber quanto em renda o trabalhador ganhou
        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
