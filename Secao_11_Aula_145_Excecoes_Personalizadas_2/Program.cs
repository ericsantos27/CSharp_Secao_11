using System;
using Secao_11_Aula_145_Excecoes_Personalizadas_2.Entidades;
using Secao_11_Aula_145_Excecoes_Personalizadas_2.Entidades.Exceptions;

namespace Secao_11_Aula_145_Excecoes_Personalizadas_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Data de check-in (dd/mm/yyyy): ");
                DateTime checkInDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/mm/yyyy): ");
                DateTime checkOutDate = DateTime.Parse(Console.ReadLine());

                Reservation reservationData = new Reservation(roomNumber, checkInDate, checkOutDate);
                Console.WriteLine(reservationData);
                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar reserva: ");
                Console.Write("Data de check-in (dd/mm/yyyy): ");
                checkInDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/mm/yyyy): ");
                checkOutDate = DateTime.Parse(Console.ReadLine());

                reservationData.UpdateDates(checkInDate, checkOutDate);
                Console.WriteLine(reservationData);
            }
            catch(DomainExceptons except)
            {
                Console.WriteLine("Erro: {0}", except.Message);
            }
        }
    }
}
