using System;

namespace _05._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int getal1, getal2, resultaat;

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse( invoer, out getal1));

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal2));

            if (getal1 > getal2)
            {
                resultaat = getal1 - getal2;
                Console.WriteLine($"{getal1} - {getal2} = {resultaat}");
            }
            else
            {
                resultaat = getal2 - getal1;
                Console.WriteLine($"{getal2} - {getal1} = {resultaat}");
            }
        }
    }
}
