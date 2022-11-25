using System;

namespace _02._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());

            if (getal1 == 1)
            {
                Console.WriteLine("0 punten.");
            }
            else if (getal1 == 2)
            {
                Console.WriteLine("20 punten.");
            }
            else if (getal1 == 3)
            {
                Console.WriteLine("50 punten.");
            }
            else
            {
                Console.WriteLine("100 punten.");
            }
        }
    }
}
