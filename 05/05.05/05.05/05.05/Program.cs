using System;

namespace _05._05
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 0;
			int total = 0;
			do
			{
				string stringDart = Console.ReadLine();

				if (stringDart.Equals("1"))
				{
					Console.WriteLine("Gut");
					i++;
				}
				else if (stringDart.Equals("2"))
				{
					total += 20;
					i++;
				}
				else if (stringDart.Equals("3"))
				{
					total += 50;
					i++;
				}
				else if (stringDart.Equals("4"))
				{
					total += 100;
					i++;
				}

			} while (i < 3);

			Console.WriteLine("U hebt " + total + " punten behaald");
		}
    }
}
