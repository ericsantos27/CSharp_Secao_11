using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_11_Aula_143_Excecoes_Personalizadas_1.Entidades
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int room, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = room;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime inn, DateTime outt)
        {
            CheckIn = inn;
            CheckOut = outt;
        }

        public override string ToString()
        {
            return "Reserva: Quarto " + RoomNumber + "; Check-in: " + CheckIn.ToString("dd/MM/yyyy" ) + "; Check-out: " + CheckOut.ToString("dd/MM/yyyy")
            + "; Diárias: " + Duration();
        }
    }
}
