using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o TimeSpan tipo (struk)
            TimeSpan t0 = new TimeSpan();
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(ticks:900000000L);//L de long pelo comprimento da numeração
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 30, 50);
            TimeSpan t5 = new TimeSpan(2, 5, 30, 55, 325);

            //iremos instanciar com as informações do que queremos saber de quanto tempo
            
            TimeSpan t6 = TimeSpan.FromDays(1.5);   //represetação de um dia e meio
            TimeSpan t7 = TimeSpan.FromHours(1.5);  
            TimeSpan t8 = TimeSpan.FromSeconds(35);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);



            
            Console.WriteLine(t0); //show timeSpan zerado
            Console.WriteLine(t1); //show thes ticks
            Console.WriteLine(t1.Ticks); //show misegundos 
            Console.WriteLine(t2);
            Console.WriteLine(t3); //Show Hours, minutes, e segunds 
            Console.WriteLine(t4); //Show the Day,Hours, Minutes e segunds
            Console.WriteLine(t5); //Show the Day, Hours, Minutos, segunds, Milesegundos

            Console.WriteLine("----------------------------");
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);


            Console.ReadKey();
        }
    }
}
