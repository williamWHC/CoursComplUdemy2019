using System;
using System.Globalization;
using ExWorker.Entities;
using ExWorker.Entities.Enums;

namespace ExWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter with departmet's data :");
            string departName = Console.ReadLine();
            Console.WriteLine("------------ Enter with worker data ---------------");
            Console.Write("Name from worker :");
            string nameWorker = Console.ReadLine();
            Console.Write("Level Worker(Junior / Pleno / Senior ) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary : ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciando os elemementos de associações
            Department dept = new Department(departName);
            Worker worker = new Worker(nameWorker, baseSalary, level, dept);

            Console.Write("how many contract for that worker? :");
            int n = int.Parse(Console.ReadLine());

            //depois que definir a quantidade de trabalhadores precisamos criar a quantidade de contratos

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} Contract data ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                int value = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duraction (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                //instanciando um contrato
                HourContract contract = new HourContract();
                worker.AddContract(contract);
            }

            //capturar somente o mês e o ano.
            Console.WriteLine("Enter with month and year to calculer income (MM/YYYY): ");
            string yearAndMonth = Console.ReadLine();
            int month = int.Parse(yearAndMonth.Substring(0, 2));
            int year = int.Parse(yearAndMonth.Substring(3));

            //Dice from worker
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for : " + yearAndMonth + " : " + worker.InCome(year, month), CultureInfo.InvariantCulture);


        }
    }
}
