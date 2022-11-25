using System;

namespace _06._02
{
    class Program
    {
        static void Main(string[] args)
        {
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();

			if (firstName.Length != 0 && lastName.Length != 0)
			{
				int count = 0;
				string magInput = Console.ReadLine();
				while (!magInput.Equals("8"))
				{

					if (magInput.Equals("1"))
						Console.WriteLine("Wij raden \"Anna\" aan.");
					else if (magInput.Equals("2"))
						Console.WriteLine("Wij raden \"Knippie\" aan.");
					else if (magInput.Equals("3"))
						Console.WriteLine("Wij raden \"VtWonen\" aan.");
					else if (magInput.Equals("4"))
						Console.WriteLine("Wij raden \"Voetbal international\" aan.");
					else if (magInput.Equals("5"))
						Console.WriteLine("Wij raden \"Wandelen & fietsen\" aan.");
					else if (magInput.Equals("6"))
						Console.WriteLine("Wij raden \"Zoom NL\" aan.");
					else if (magInput.Equals("7"))
						Console.WriteLine("Wij raden \"Runners\" aan.");

					count++;
					magInput = Console.ReadLine();
				}

				if (count == 0)
					Console.WriteLine("Wij raden niets aan.");
			}
		}
    }
}
