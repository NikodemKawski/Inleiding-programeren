using System;

namespace _04._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberstring = Console.ReadLine();
            int number = int.Parse(numberstring);

            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
        }
    }
}
