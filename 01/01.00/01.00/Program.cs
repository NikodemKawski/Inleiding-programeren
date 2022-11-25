using System;

namespace _01._00
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, product, som;

            //inlezen
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());

            //bewerking
            som = (getal1 * 2) + (getal2 * 2);
            product = getal1 * getal2;

            //resultaat tonen
            Console.WriteLine("Omtrek: " + som);
            Console.WriteLine($"Oppervlakte: {product}");

            Console.ReadLine();
        }
    }
}
