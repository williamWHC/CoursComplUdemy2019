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
        public Department Department { get; set; }
        public HourContract Contract { get; set; }


        //Construtor da Class
        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double basesalary)
        {
            Name = name;
            Level = level;
            BaseSalary = basesalary;
        }

        //metodos
        public void AddContract(HourContract contract)
        {
             
        }

    }
}
