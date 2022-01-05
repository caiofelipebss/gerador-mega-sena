using System;

namespace SugestaoMegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **** Sugestão Mega-Sena **** ");
            Console.WriteLine("******************************");
            Console.WriteLine();

            var randNum = new Random();
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($" {randNum.Next(1, 60)} ");
            }
            
            Console.ReadKey();
        }
    }
}
