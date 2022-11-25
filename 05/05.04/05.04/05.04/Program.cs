using System;

namespace _05._04
{
    class Program
    {
        static void Main(string[] args)
        {
			string correctString = "Op de stoel ligt een zonnehoed en peperkoek";
			Console.WriteLine(correctString);

			string key = Console.ReadLine();
			if (key.Equals(""))
				Console.Clear();

			string stringInput;
			int tryAmount = 0;
			do
			{
				stringInput = Console.ReadLine();
				tryAmount++;
			} while (!(stringInput.Equals(correctString)));

			if (tryAmount == 1)
				Console.WriteLine("Je had " + tryAmount + " poging nodig!"); // Singular verb 'poging'
			else
				Console.WriteLine("Je had " + tryAmount + " pogingen nodig!"); // Multiple so 'pogingEN'
		}
    }
}
