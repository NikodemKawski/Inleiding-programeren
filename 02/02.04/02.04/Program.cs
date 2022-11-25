using System;

namespace _02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());

            //bewerking + print

            if ((getal1 % 5 == 0) && (getal1 % 11 == 0))
            {
                Console.WriteLine("Deelbaar.");
            }
            else
            {
                Console.WriteLine("Niet deelbaar.");
            }
        }
    }
}
