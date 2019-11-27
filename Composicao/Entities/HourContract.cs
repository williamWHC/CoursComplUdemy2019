using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            this.Date = date;
            this.ValuePerHour = valueperhour;
            this.Hours = hours;
        }

        public double TotalValue()
        {
            return this.Hours * this.ValuePerHour;
        }
    }
}
