using System;

namespace _03._00
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter, uitvoer;

            Console.Write("Geef een letter: ");
            letter = Console.ReadLine().ToLower();

            switch (letter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    uitvoer = "Klinker.";
                    break;

                default:
                    uitvoer = "Medeklinker.";
                    break;
            }

            Console.WriteLine($"{uitvoer}");
        }
    }
}
