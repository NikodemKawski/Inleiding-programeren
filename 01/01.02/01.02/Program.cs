using System;

namespace _01._02
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
            product = ((getal1 / 100) * getal2) + getal1;

            //uitprinten
            Console.WriteLine($"Prijs inclusief BTW: {product}");

            Console.WriteLine();
        }
    }
}
