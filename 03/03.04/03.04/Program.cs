using System;

namespace _03._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            string naam;
            string voornaam;
            

            Console.Write("Naam: ");
            naam = Console.ReadLine();

            Console.Write("Voornaam: ");
            voornaam = Console.ReadLine().ToUpper();

            Console.Write("Hobby: ");
            getal = int.Parse(Console.ReadLine());

            if (getal == 1)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Anna\"", naam, voornaam);
            }
            else if (getal == 2)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Knippie\"", naam, voornaam);
            }
            else if (getal == 3)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"VtWonen\"", naam, voornaam);
            }
            else if (getal == 4)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Voetbal international\"", naam, voornaam);
            }
            else if (getal == 5)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Wandelen & fietsen\"", naam, voornaam);
            }
            else if (getal == 6)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Zoom NL\"", naam, voornaam);
            }
            else if (getal == 7)
            {
                Console.WriteLine("{0} {1}, tijdschrift: \"Runners\"", naam, voornaam);
            }
            else
            {
                Console.WriteLine("{0} {1}, tijdschrift: -", naam, voornaam);
            }
        }
    }
}
