using System;

namespace _06._03
{
	class Program
	{
		static void Main(string[] args)
		{
			string ploeg, symbEen, symbTwee;
			string output = string.Empty;
			int lengte, breedte;


            do
            {
				ploeg = Console.ReadLine();
            } while (ploeg.Length <= 5 && ploeg != "*****");

            while (ploeg != "*****")
            {
				output += ploeg + "\n";

				symbEen = Console.ReadLine();
				symbTwee = Console.ReadLine();

                do
                {
					lengte = int.Parse(Console.ReadLine());
                } while (lengte < 4);

                do
                {
					breedte = int.Parse(Console.ReadLine());
                } while (breedte <= lengte / 2);

				bool isEen = true;
                for (int i = 0; i < lengte; i++)
                {
                    if (isEen)
                    {
                        for (int j = 0; j < breedte; j++)
                        {
                            output += symbEen;
                        }
                        isEen = false;
                        output += "\n";
                    }
                    else
                    {
                        for (int j = 0; j < breedte; j++)
                        {
                            output += symbTwee;
                        }
                        isEen = true;
                        output += "\n";
                    }
                }
                do
                {
                    ploeg = Console.ReadLine();
                } while (ploeg.Length <= 5 && ploeg != "*****");
            }

            Console.Clear();
            Console.WriteLine(output);

		}

	}

}