using System;

namespace _06._04
{
    class Program
    {
        static void Main(string[] args)
        {
			int table;
			int[] allTables = new int[50];
			while (!int.TryParse(Console.ReadLine(), out table)) ;

			int count = 0;
			while (table != 0)
			{
				allTables[count] = table;

				while (!int.TryParse(Console.ReadLine(), out table)) ;
				count++;
			}

			foreach (int term in allTables)
			{
				if (term != 0)
				{
					for (int j = 1; j < 11; j++)
					{
						Console.WriteLine(j + " x " + term + " = " + (j * term));
					}
					Console.WriteLine();
				}
				else
					break;
			}
		}
    }
}