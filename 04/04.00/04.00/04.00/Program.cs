using System;

namespace _04._00
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int resultaat;

            getal = int.Parse(Console.ReadLine());

            resultaat = getal +11;

            for (int i = getal; i < resultaat; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
