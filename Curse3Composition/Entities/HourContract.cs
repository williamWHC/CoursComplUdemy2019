using System;
using System.Collections.Generic;
using System.Text;

namespace Curse3Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuesPerHour { get; set; }
        public int Hour { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valueperhour, int hour)
        {
            this.Date = date;
            this.ValuesPerHour = valueperhour;
            this.Hour = hour;
        }

        public double TotalValuesr()
        {
            return this.Hour * this.ValuesPerHour;
        }
    }
}
