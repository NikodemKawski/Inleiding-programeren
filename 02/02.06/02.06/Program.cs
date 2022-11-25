using System;

namespace _02._06
{
    class Program
    {
        static void Main(string[] args)
        {
            //delacratie
            int getal1, getal2, getal3, resultaat;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());

            //bewerking+ print

            if (((getal1 + getal2 + getal3) / 3) >= 50)
            {
                resultaat = ((getal1 + getal2 + getal3) / 3);
                Console.WriteLine("{0}, geslaagd", resultaat);
            }
            else
            {
                resultaat = ((getal1 + getal2 + getal3) / 3);
                Console.WriteLine("{0}, niet geslaagd", resultaat);
            }
        }
    }
}
