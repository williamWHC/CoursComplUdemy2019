using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDataEHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;

            //Imprime a data atual e a Hora atual
            Console.WriteLine(d1);
            //Imprime o código de data e hora
            Console.WriteLine(d1.Ticks);

            //===========================================
            //Builder, DateTime is struck
            DateTime d2 = new DateTime(2019, 10, 30);               //is the build
            DateTime d3 = new DateTime(2019, 09, 30, 21, 50, 03);   //date the time 
            DateTime d4 = new DateTime(2019, 09, 05, 13, 45, 20, 500);

            DateTime d5 = DateTime.Now;     //New Time 
            DateTime d6 = DateTime.Today;   //Date local, time zero 
            DateTime d7 = DateTime.UtcNow;  //Horario Global
   
            //show on screen
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            //Utilizando os Parse 
            DateTime d8 = DateTime.Parse("2000-10-05");
            DateTime d9 = DateTime.Parse("2001-11-10 13:20:58");

            //Padrao brasileiro
            DateTime d10 = DateTime.Parse("17/02/1991");
            DateTime d11 = DateTime.Parse("17/02/1991 17:02:51");

            DateTime d12 = DateTime.ParseExact("1991-02-17", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("17/02/1991 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


 
            Console.ReadLine();
        }
    }
}
