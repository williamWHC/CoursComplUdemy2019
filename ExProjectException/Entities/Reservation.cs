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

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            this.CheckIn = checkIn;
            this.CheckOut = CheckOut;
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
