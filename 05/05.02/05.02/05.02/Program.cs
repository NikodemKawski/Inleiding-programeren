using System;

namespace _05._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, getal4, getal5, aantaljaren, resultaat;

            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());
            getal5 = int.Parse(Console.ReadLine());
            aantaljaren = int.Parse(Console.ReadLine());


            if (aantaljaren == 1)
            {
                resultaat = (getal1 + getal2 + getal3 + getal4 + getal5) - 5;
            }
            else if (aantaljaren == 2)
            {
                resultaat = (getal1 + getal2 + getal3 + getal4 + getal5) - 10;
            }
            else if (aantaljaren == 3)
            {
                resultaat = (getal1 + getal2 + getal3 + getal4 + getal5) - 20;
            }
            else if (aantaljaren == 4)
            {
                resultaat = (getal1 + getal2 + getal3 + getal4 + getal5) - 30;
            }
            else
            {
                resultaat = (getal1 + getal2 + getal3 + getal4 + getal5) - 50;
            }

            Console.WriteLine($"Totaalprijs: {resultaat} euro");
        }
    }
}
