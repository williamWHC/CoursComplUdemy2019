using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePropriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(1991, 2, 17, 2, 30, 58, 275);

            Console.WriteLine(d1);
            Console.WriteLine("1) Date: " + d1.Date); //Extrai apenas a Data
            Console.WriteLine("2) Day: "+ d1.Day);  //Extrai o Dia
            Console.WriteLine("3) Hours: "+ d1.Hour); //Extrai apenas a horas
            Console.WriteLine("4) Minutes: "+ d1.Minute); //Exgtrai apenas os minutos
            Console.WriteLine("4) Seconds: "+ d1.Second);   //Extrai apenas os segundos
            Console.WriteLine("5) Milesegundos: "+ d1.Millisecond); //Extraapenas os milisegundos
            Console.WriteLine("6) Tckes: "+ d1.Ticks);

            Console.WriteLine("7) DayOfWeek: " + d1.DayOfWeek); //Dia da semana
            Console.WriteLine("8) DayOfYear: " + d1.DayOfYear); //Dia do ano
            Console.WriteLine("9) King: " + d1.Kind);           //
            Console.WriteLine("10) "+ d1.Month);                //Mês
            Console.WriteLine("11) "+ d1.TimeOfDay);            //Horario do Dia instanciado
            Console.WriteLine("12) "+ d1.Year);                 //Ano mencionado

            Console.WriteLine("=============================================");
            //Conversões com funcões

            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());

            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());

            Console.WriteLine(d1.ToString());
            //Mascara de Formatação com ToString
            Console.WriteLine(d1.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            Console.WriteLine("=================================================");
            //DateTime trabalahndo com manipulações 
            DateTime h1 = new DateTime(2000, 02, 14);
            DateTime g1 = new DateTime(2000, 02, 17);
            DateTime g2 = g1.AddHours(2);
            DateTime g3 = g1.AddDays(7);
            DateTime g4 = g1.AddMinutes(3);

            TimeSpan t = g1.Subtract(h1);


            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.WriteLine(g3);
            Console.WriteLine(g4);
            Console.WriteLine(h1);  //mostra a variavel com as datas colocadas

            Console.WriteLine(t); //Subtrai as Diferenças de dia das datas instanciadas


            
            






            Console.ReadKey();
        }
    }
}
