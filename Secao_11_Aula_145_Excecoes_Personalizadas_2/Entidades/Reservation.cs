using System;
using System.Collections.Generic;
using System.Text;
using Secao_11_Aula_145_Excecoes_Personalizadas_2.Entidades.Exceptions;

namespace Secao_11_Aula_145_Excecoes_Personalizadas_2.Entidades
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
            if(CheckOut <= CheckIn)
            {
                throw new DomainExceptons("A data de saída deve ser maior que a data de entrada");
            }
            
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
            DateTime today = DateTime.Now;
            if(CheckIn < today || CheckOut < today)
            {
                throw new DomainExceptons("Alterações de reserva somente para datas futuras");
            }
            if(CheckOut <= CheckIn)
            {
                throw new DomainExceptons("A data de saída deve ser maior que a data de entrada");
            }

            CheckIn = inn;
            CheckOut = outt;
        }

        public override string ToString()
        {
            return "Reserva: Quarto " + RoomNumber + "; Check-in: " + CheckIn.ToString("dd/MM/yyyy") + "; Check-out: " + CheckOut.ToString("dd/MM/yyyy")
            + "; Diárias: " + Duration();
        }
    }
}
