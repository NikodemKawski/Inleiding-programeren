using System;

namespace Voorbeeld1_selectie_deel1
{
    class Program
    {
        static void Main(string[] args)
        {
            string activiteit, tijdstip, antwoord;
            bool benJeVrij;

            Console.Title = "Voorbeeld 1";

            Console.WriteLine("\tOntvangen SMS-Bericht");
            Console.Write("\n\tVoor activiteit kreeg je een sms-bericht? ");
            activiteit = Console.ReadLine();

            Console.Write("\tWanneer gaat \"{0}\" door? ", activiteit);
            tijdstip = Console.ReadLine();

            Console.Write("\tBen je vrij op {0} (\"true\" of \"false\")? ", tijdstip);
            benJeVrij = bool.Parse(Console.ReadLine());

            if (benJeVrij == true)
            {
                antwoord = "Ik zal er zijn!";
            }
            else
            {
                antwoord = "Spijtig, ik kan niet!";
            }

            Console.WriteLine("\n\t{0}", antwoord);

            Console.WriteLine();
            Console.Write("\tDruk op enter om verder te gaan!");
            Console.ReadLine();
        }
    }
}
