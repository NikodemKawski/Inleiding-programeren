using System;

namespace _01._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, getal4, som, product;

            //inlezen
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            //bewerking uitvoeren
            som = getal1 + getal3;
            product = getal2 * getal4;

            //resultaat tonen
            Console.WriteLine("Optelling: " + som);
            Console.WriteLine($"Vermenigvuldiging: {product}");

            Console.WriteLine();
        }
    }
}
