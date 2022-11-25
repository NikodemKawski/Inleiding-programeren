using System;

namespace _03._03
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1, getal2, getal3, resultaat;
            string code;

            getal1 = double.Parse(Console.ReadLine());
            getal2 = double.Parse(Console.ReadLine());
            getal3 = double.Parse(Console.ReadLine());
            code = Console.ReadLine().ToLower();

            if (code == "a")
            {
                resultaat = getal1 + getal2 + getal3;
                Console.WriteLine("Uitkomst: {0}", resultaat);
            }
            else if (code == "b")
            {
                resultaat = getal1 * getal3;
                Console.WriteLine("Uitkomst: {0}", resultaat);
            }
            else if (code == "c")
            {
                resultaat = getal3 - getal2;
                Console.WriteLine("Uitkomst: {0}", resultaat);
            }
            else if (code == "d")
            {
                if (getal1 > 0)
                {
                    resultaat = Math.Sqrt(getal1);
                    Console.WriteLine("Uitkomst: {0}", resultaat);
                }
                else
                {
                    Console.WriteLine("Foutieve invoer.");
                }
            }
            else
            {
                resultaat = Math.Max(getal1, Math.Max(getal2, getal3));
                Console.WriteLine("Uitkomst: {0}", resultaat);
            }
        }
    }
}
