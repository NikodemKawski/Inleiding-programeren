using System;

namespace _06._05
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] allNames = new string[50];
			int[] allScores = new int[50];
			int total = 0;
			int count = 0;
			int tempAmount = 0;

			string name = Console.ReadLine();
			while (!name.Equals(""))
			{
				while (!int.TryParse(Console.ReadLine(), out tempAmount)) ;
				allNames[count] = name;
				allScores[count] = tempAmount;
				total += tempAmount;

				name = Console.ReadLine();
				count++;
			}

			for (int i = 0; i < count; i++)
			{
				Console.WriteLine(allNames[i] + " (" + allScores[i] + ")");
			}
			Console.WriteLine("Gemiddelde: " + total / count);
		}
    }
}
