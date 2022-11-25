using System;
using System.Collections.Generic;

namespace _07._05
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> numbers = new List<int>();
			int maxNum = 0;
			int minNum = 0;

			int number;
			while (!int.TryParse(Console.ReadLine(), out number)) ;

			while (number != 0)
			{
				numbers.Add(number);

				while (!int.TryParse(Console.ReadLine(), out number)) ;
			}

			int sum = 0;
			for (int i = 0; i < numbers.Count; i++)
			{

				sum += numbers[i];

				if (i == 0)
				{
					maxNum = numbers[i];
					minNum = numbers[i];
				}

				if (numbers[i] > maxNum)
					maxNum = numbers[i];

				if (numbers[i] < minNum)
					minNum = numbers[i];
			}

			Console.WriteLine("Statistieken:");
			Console.WriteLine("Hoogste cijfer: " + maxNum.ToString());
			Console.WriteLine("laagste cijfer: " + minNum.ToString());
			Console.WriteLine("Gemiddelde: " + (sum / numbers.Count).ToString());
		}
    }
}
