using System;
using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Enter: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/Plano/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine(worker);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            //Fazer as entrada de dados, par serem percoridas para cada contrato
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} Contract data");   //Percorendo a quantidade de contratos digitados
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Values per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

                Console.WriteLine();
                Console.Write("Enter month and year to calculate income (MM/YYYY): "); //insira mês e ano para calcular renda
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3));

                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Department: " + worker.Department.Name);
                Console.WriteLine("Income for" + monthAndYear + " : " + worker.Income(year, month));


             
            }
            
        }
    }
}
