using System;
using System.IO;

namespace StreamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\willi\source\repos\williamWHC\CoursComplUdemy2019\file1.txt";
            string targetPath = @"C:\Users\willi\source\repos\williamWHC\CoursComplUdemy2019\file2.txt";

            try
            {
                //vetor de todos os vetores
                string[] lines = File.ReadAllLines(sourcePath);


                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occuured"); //Um erro occoreu
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
