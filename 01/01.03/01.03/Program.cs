using System;

namespace _01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2, som;

            //inlezen
            getal1 = double.Parse(Console.ReadLine());
            getal2 = double.Parse(Console.ReadLine());

            //bewerking
            som = (getal1 * 10) + (getal2 * 7.5);

            //printen
            Console.WriteLine($"Totaal te betalen: {som} euro");

            Console.ReadLine();
        }
    }
}
