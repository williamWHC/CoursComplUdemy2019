using System;
using System.Collections.Generic;
using System.Text;

namespace ExProjectException.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }         // Numero de Quartos
        public DateTime CheckIn { get; set; }       // Verbo dar entrada
        public DateTime CheckOut { get; set; }      // Verificação de saida

        public Reservation()
        {
        }

        public Reservation(int roomnumber, DateTime checkin, DateTime checkout)
        {
            this.RoomNumber = roomnumber;
            this.CheckIn = checkin;
            this.CheckOut = checkout;
        }

        //TimeSpan - representa a deferença entre duas datas datetime
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Erro a data mencionada é anterio a atual";
            }
            if (checkOut <= checkIn)
            {
                return "Erro a data de sair é menor que a data de entrada";
            }

            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            return null; //indicando que não teve nenhum erro
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", Check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", "
                + ", Check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", Day: "
                + Duration()
                + " nights";
        }
    }
}
