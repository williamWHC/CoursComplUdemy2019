using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSwitchCase01
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            string day;

            switch (d)
            {
                case 1:
                    day = "Sunday - (Segunda)";
                    break;

                case 2:
                    day = "Monday - (Terça)";
                    break;

                case 3:
                    day = "Tuesday - (Quarta)";
                    break;

                case 4:
                    day = "Wednesday - (Quinta)";
                    break;

                case 5:
                    day = " ThursDay  - (Sexta)";
                    break;

                case 6:
                    day = "Friday - (Sabado)";
                    break;

                case 7:
                    day = "Saturday - (Domingo)";
                    break;

                default:
                    day = "Invalid values";
                    break;
            }

        }
    }
}
