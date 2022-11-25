using System;
using System.Collections.Generic;

namespace _07._04
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> nameList = new List<string>();
			string longestWord = "";
			string shortestWord = "";

			string inputName = Console.ReadLine();
			while (!inputName.Equals(""))
			{
				nameList.Add(inputName);
				inputName = Console.ReadLine();
			}


			for (int i = 0; i < nameList.Count; i++)
			{

				if (i == 0)
				{
					longestWord = nameList[i];
					shortestWord = nameList[i];
				}

				if (nameList[i].Length > longestWord.Length)
					longestWord = nameList[i];

				if (nameList[i].Length < shortestWord.Length)
					shortestWord = nameList[i];
			}

			int indexCount = nameList.IndexOf(longestWord) + nameList.IndexOf(shortestWord);

			Console.WriteLine("Het langste woord is " + longestWord);
			Console.WriteLine("Het kortste woord is " + shortestWord);
			Console.WriteLine("De som van de posities is " + indexCount.ToString());
		}
    }
}