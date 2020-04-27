using System;
using System.IO;

namespace FileStreamAndStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Worker with FileStream and StreamReader
            string path = @"C:\Windows\Temp\file1.txt";
            StreamReader sr = null;

            try
            {
                //sr = new StreamReader(fs);
                //string line = sr.ReadLine();
                //Console.WriteLine(line);
                //defini o fluxo do arquivo e chama o metodo de modo de arquivo aberto
                //le o arquivo, captura a primeira linha do arquivo capturado
                //fs = new FileStream(path, FileMode.Open);

                sr = File.OpenText(path);           //Abre um arquivo de texto codificado
                while (!sr.EndOfStream)             //enquanto o sr não chegar no fim do fluxo, mostre 
                {
                    string lines = sr.ReadLine();
                    Console.WriteLine(lines);
                    Console.ReadKey();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("An erro accurred"); //Um erro ocorreu
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                //if (sr != null) sr.Close();
                //if (fs != null) sr.Close();
            }
            
        }
    }
}
