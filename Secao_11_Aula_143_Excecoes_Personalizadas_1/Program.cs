using System;
using Secao_11_Aula_143_Excecoes_Personalizadas_1.Entidades;

namespace Secao_11_Aula_143_Excecoes_Personalizadas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quarto: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Data de check-in (dd/mm/yyyy): ");
            DateTime checkInnDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de check-out (dd/mm/yyyy): ");
            DateTime checkOutDate = DateTime.Parse(Console.ReadLine());
            
            if(checkInnDate > checkOutDate)
            {
                Console.WriteLine("A data de saída deve ser maior que a data de entrada");
            }
            else
            {
                Reservation reservationData = new Reservation(roomNumber, checkInnDate, checkOutDate);
                Console.WriteLine(reservationData);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualização da reserva: ");
                Console.Write("Data de check-in (dd/mm/yyyy): ");
                checkInnDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/mm/yyyy): ");
                checkOutDate = DateTime.Parse(Console.ReadLine());

                DateTime today = DateTime.Now;
                if (checkInnDate < today || checkOutDate < today)
                {
                    Console.WriteLine("Alterações de reserva somente para datas futuras");
                }
                else if (checkInnDate > checkOutDate)
                {
                    Console.WriteLine("A data de saída deve ser maior que a data de entrada");
                }
                else
                {
                    reservationData.UpdateDates(checkInnDate, checkOutDate);
                    Console.WriteLine(reservationData);
                }
            }
        }
    }
}
