using System;

namespace _04._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string antwoord = default;
            int geluksGetal;

            naam = Console.ReadLine();
            geluksGetal = int.Parse(Console.ReadLine());

            for (int i = 0; i < geluksGetal; i++)
            {
                antwoord += (naam + " ");
            }
            Console.WriteLine($"{geluksGetal} {antwoord}");
        }
    }
}
