using System;

namespace _02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, quotient;
            string resulaatbij0;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            resulaatbij0 = " is niet deelbaar door 0.";

            //bewerking + uitprinten
            if (getal2 == 0)
            {
                Console.WriteLine(getal1 + resulaatbij0);
            }
            else
            {
                quotient = getal1 / getal2;
                Console.WriteLine("\n{0} / {1} = {2}", getal1, getal2, quotient);
            }
            
        }
    }
}
