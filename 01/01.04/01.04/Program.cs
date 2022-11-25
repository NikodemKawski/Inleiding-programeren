using System;

namespace _01._04
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2, product;

            //inlezen
            getal1 = double.Parse(Console.ReadLine());
            getal2 = double.Parse(Console.ReadLine());

            //bewerking
            product = (((getal1 + getal2) * 0.12) + 23) * 1.21;

            //printen
            Console.WriteLine($"Totaal te betalen: {product} euro");

            Console.ReadLine();
        }
    }
}
