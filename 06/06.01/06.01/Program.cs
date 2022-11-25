using System;

namespace _06._01
{
    class Program
    {
        static void Main(string[] args)
        {
			string askEvent = Console.ReadLine();

			string[] nameList = new string[50];
			int index = 0;
			while (Console.ReadLine().Equals("ja"))
			{
				nameList[index] = Console.ReadLine();
				index++;
			}

			if (index == 0)
				Console.WriteLine("Er zijn geen aanwezigen voor " + askEvent + "!");
			else
			{
				Console.WriteLine("Aanwezigen voor " + askEvent + ":");
				foreach (string name in nameList)
					Console.WriteLine(name);
			}
		}
    }
}
