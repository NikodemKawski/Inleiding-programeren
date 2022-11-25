using System;

namespace _04._04
{
    class Program
    {
        static void Main(string[] args)
        {
			string char1 = Console.ReadLine();
			string char2 = Console.ReadLine();
			string numiLoopsString = Console.ReadLine();
			string numjLoopsString = Console.ReadLine();
			int numiLoops = int.Parse(numiLoopsString);
			int numjLoops = int.Parse(numjLoopsString);


			for (int i = 0; i < numiLoops; i++)
			{
				for (int j = 0; j < numjLoops; j++)
				{
					if (i % 2 == 0)
						Console.Write(char1);
					else
						Console.Write(char2);
				}
				Console.WriteLine();
			}
		}
    }
}
