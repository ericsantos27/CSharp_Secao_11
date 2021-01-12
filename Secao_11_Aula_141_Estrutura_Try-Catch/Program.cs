using System;

namespace Secao_11_Aula_141_Estrutura_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("1° número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("2° número: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Resultado: {0}", result);
            }
            catch(DivideByZeroException except)
            {
                Console.WriteLine("Error !! {0}", except.Message);
            }
        }
    }
}
