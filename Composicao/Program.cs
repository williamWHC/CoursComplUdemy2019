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

            Console.Write("Enter worker data:");
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


            
        }
    }
}
