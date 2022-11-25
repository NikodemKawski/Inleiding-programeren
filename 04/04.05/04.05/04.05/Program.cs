using System;

namespace _04._05
{
    class Program
    {
        static void Main(string[] args)
        {
			string num1String = Console.ReadLine();
			string num2String = Console.ReadLine();
			int num1 = int.Parse(num1String);
			int num2 = int.Parse(num2String);

			string buffer = "";
			for (int i = num1; i >= num2; i--)
			{
				if (i != num2)
					buffer += i + " * ";
				else
					buffer += i;
			}

			Console.WriteLine(buffer);
		}
    }
}
