using System;

namespace _05._00
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            double hoeveelheid;
            int tijd = 0;

            do
            {
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out hoeveelheid));

            do
            {
                tijd += 5;
                hoeveelheid = hoeveelheid / 2;
            } while (hoeveelheid > 1);

            Console.WriteLine($"Totale tijd: {tijd} uur");
            Console.ReadLine();
        }
    }
}
