using System;
using System.Collections.Generic;
using System.Text;

namespace ExWorker.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        //Builder
        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        //Custom Methods
        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }


    }
}
