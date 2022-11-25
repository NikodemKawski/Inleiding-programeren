using System;

namespace _05._03
{
    class Program
    {
        static void Main(string[] args)
        {
			int i = 0;
			int yCount = 0;
			int nCount = 0;
			do
			{
				char pasInput = Console.ReadLine()[0]; // Only read first character
				if (pasInput.Equals('Y'))
				{
					yCount++;
					i++;
				}
				else if (pasInput.Equals('N'))
				{
					nCount++;
					i++;
				}
			} while (i < 8 && yCount < 4);

			int totalPassengers = yCount + nCount;

			Console.WriteLine("Er zijn " + totalPassengers + " passagiers. " + yCount + " zitten er aan het raam.");
		}
    }
}
