using System;

namespace _03._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaartal;
            string geenOfEen = "geen";
            jaartal = int.Parse(Console.ReadLine());
            if (jaartal > 1582)
            {
                // Groter dan 1582
                if (jaartal % 4000 == 0)
                {
                    // Deelbaar door 4000
                    geenOfEen = "geen";
                }
                else if (jaartal % 400 == 0)
                {
                    // Deelbaar door 400
                    geenOfEen = "een";
                }
                else if (jaartal % 100 == 0)
                {
                    // Deelbaar door 100
                    geenOfEen = "geen";
                }
                else if (jaartal % 4 == 0)
                {
                    // Deelbaar door 4
                    geenOfEen = "een";
                }
                else
                {
                    // Al het andere
                    geenOfEen = "geen";
                }
            }
            else
            {
                // Kleiner dan 1582
                if (jaartal % 4 == 0)
                {
                    // Jaartal deelbaar door 4
                    geenOfEen = "een";
                }
                else
                {
                    // Jaartal niet deelbaar door 4
                    geenOfEen = "geen";
                }
            }
            Console.WriteLine($"{jaartal} is {geenOfEen} schrikkeljaar.");
        }
    }
}