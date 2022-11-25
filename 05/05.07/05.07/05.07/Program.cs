using System;

namespace _05._07
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int tafel, uitkomst, score = 0;



            do
            {
                Console.Write("Geef tafel in: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out tafel));

            for (int i = 1; i <= 10; i++)
            {
                do
                {
                    Console.Write($"{tafel} x {i} = ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out uitkomst));

                if (uitkomst == (tafel * i)) ;
                {
                    score++;
                }
            }

            Console.WriteLine($"U heeft {score}/10 behaald!");
            Console.ReadLine();
        }
    }
}
