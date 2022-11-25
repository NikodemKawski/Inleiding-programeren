using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie
            int getal1, getal2, getal3, getal4, som, product;

            // schermkleur aanpassen
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Oefening 1";

            //inlezen
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            //bewerking uitvoeren
            som = getal1 + getal3;
            product = getal2 * getal4;

            //resulaat tonen
            Console.WriteLine("Som: " + som);
            Console.WriteLine($"Product: {product}");

            Console.ReadLine();
        }
    }
}
