using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionCurse.Entities
{
    class HourPerContract
    {
        public DateTime Date { get; set; }                          //Data do Contrato
        public double ValuePerHour { get; set; }                    //ValorPorHora do Contrato
        public int Hours { get; set; }                              //Horas do contrato

        //Contrutor padrao
        public HourPerContract()
        {

        }

        public HourPerContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //metodo para saber valor por horas * as horas trabalhadas
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
