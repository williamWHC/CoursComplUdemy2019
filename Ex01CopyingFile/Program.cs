using System;
using System.IO;

namespace Ex01CopyingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo => Informação do Arquivo
            //caminhos de origem e destino do arquivo
            string sourcePath = @"C:\Windows\Temp\file1.txt";   
            string targetPath = @"C:\Windows\Temp\file2.txt";   

            try
            {
    

                //declaração da class file and fileInfo
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                
            }
            catch (IOException e)
            { 
                Console.WriteLine("An erro occurent");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
