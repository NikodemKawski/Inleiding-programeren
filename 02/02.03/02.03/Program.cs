using System;

namespace _02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;

            //inlezen
            
            string voornaam = Console.ReadLine();
            string familienaam = Console.ReadLine();
            getal1 = int.Parse(Console.ReadLine());

            //bewerking + uitdrukken

            if (getal1 >= 18)
            {
                
                Console.WriteLine("{0} {1}: Volwassenen", voornaam, familienaam);
            }
            else
            {
                Console.WriteLine("{0} {1}: Jeugd", voornaam, familienaam);
            }
        }
    }
}
