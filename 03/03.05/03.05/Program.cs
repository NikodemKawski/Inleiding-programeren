using System;

namespace _03._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string output;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x == 0 && y == 0)
            {
                // Oorsprong
                output = "de oorsprong.";
            }
            else if (x >= 0)
            {
                if (y >= 0)
                {
                    // Kwadrant 1
                    output = "het eerste kwadrant.";
                }
                else
                {
                    // Kwadrant 4
                    output = "het vierde kwadrant.";
                }
            }
            else
            {
                if (y >= 0)
                {
                    // Kwadrant 2
                    output = "het tweede kwadrant.";
                }
                else
                {
                    // Kwadrant 3
                    output = "het derde kwadrant.";
                }
            }
            Console.WriteLine($"Punt ligt in {output}");
        }
    }
}