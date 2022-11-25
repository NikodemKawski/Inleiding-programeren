using System;

namespace _06._00
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int getal, totaal = 0;

            //PR 1
            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal));

            //PR 2
            while (getal > 0)
            {
                //PR 3
                totaal += getal;

                //PR 4
                do
                {
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out getal));

            }

            Console.WriteLine($"Totaal: {totaal}");
        }
    }
}
