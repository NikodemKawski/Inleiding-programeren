using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, resultaat;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());

            //bewerking + uitdrukken
            if (getal1 >= getal2)
            {
                resultaat = getal1 - getal2;
                Console.WriteLine("\n{0} - {1} = {2}", getal1, getal2, resultaat);
            }
            else 
            {
                resultaat = getal2 - getal1;
                Console.WriteLine("\n{1} - {0} = {2}", getal1, getal2, resultaat);
            }

            
        }
    }
}
