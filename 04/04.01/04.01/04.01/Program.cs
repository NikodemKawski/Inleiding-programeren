using System;

namespace _04._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = 0, nieuwGetal;
            int aantalGetallen = 10;

            getal = int.Parse(Console.ReadLine());

            for (int i = 1; i < aantalGetallen; i++)
            {
                nieuwGetal = int.Parse(Console.ReadLine());
                getal += nieuwGetal;
            }
            Console.WriteLine($"Som: {getal}");
        }
    }
}
