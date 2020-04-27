using System;
using System.IO;

namespace UsingUserWithExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the (User) with example

            string Path = @"C:\Users\willi\source\repos\williamWHC\CoursComplUdemy2019\file1.txt";
            StreamReader sr = null;

            try
            {
                using (sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured"); //Um erro occorido
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
