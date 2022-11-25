using System;

namespace Bookshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string naamKlant, boeknaam;

            do
            {
                Console.Write("Naam klant: ");
                naamKlant = Console.ReadLine();
            } while (string.IsNullOrEmpty(naamKlant));

            Console.Write("Wilt u een boek toevoegen? ");
            string boekToevoegen = Console.ReadLine();

            while (boekToevoegen == "ja")
            {
                Console.Write("Naam boek: ");
                boeknaam = Console.ReadLine();

                for (int i = 0; i < max; i++)
                {

                }
            }
        }
    }
}
