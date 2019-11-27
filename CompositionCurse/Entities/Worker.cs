using System;
using System.Collections.Generic;
using System.Text;
using CompositionCurse.Entities.Enums;
namespace CompositionCurse.Entities
{
    class Worker
    {
        public int Name { get; set; }
        //v-- Criar um enumerado
        public WorkerLevel Level { get; set; }
        public double  SalaryBase { get; set; }
        //v-- Criando uma Composição/Associação com Department--v
        public Department Department { get; set; }
        //v-- realizar uma associação com a class HourPerContract = Um trabalhador para varios contratos
        public List<HourPerContract> Contracts { get; set; } = new List<HourPerContract>();

        public Worker()
        {

        }

        //Contrutor, terirar associações para muitos
        public Worker(int name, WorkerLevel level, double salaryBase, Department department, List<HourPerContract> contracts)
        {
            Name = name;
            Level = level;
            SalaryBase = salaryBase;
            Department = department;
            Contracts = contracts;
        }
        
        //Adcionando um contrato ao trabalahador
        public void AddContract(HourPerContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourPerContract contract)
        {
            Contracts.Remove(contract);
        }

        //Criar o metodo do ganho do trabalhador (Renda)
        public double Income(int year, int month)
        {
            double sum = SalaryBase;

            foreach (HourPerContract contract in Contracts)
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
