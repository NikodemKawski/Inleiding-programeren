using System;

namespace Getal_raden
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            
            Random random = new Random();

            while (run)
            {
                int rnd = random.Next(1, 6);

                Console.Write("Geef een getal in: ");
                int trys = 0;
                bool solved = false;
                while (!solved)
                {
                    trys++;
                    int guess;
                    bool numericGuess;
                    do
                    {
                        numericGuess = int.TryParse(Console.ReadLine(), out guess);
                        if (!numericGuess)
                        {
                            Console.Write("Geef een getal in: ");
                        }
                    } while (!numericGuess);

                    if (guess > rnd)
                    {
                        Console.WriteLine("Helaas dit is niet het juiste getal... \n");
                        Console.Write("Geen nog een getal in: ");
                    }
                    else if (guess < rnd)
                    {
                        Console.WriteLine("Helaas dit is niet het juiste getal... \n");
                        Console.Write("Geen nog een getal in: ");
                    }
                    else if (guess == rnd)
                    {
                        solved = true;
                        Console.WriteLine(string.Format("Goed zo! Je had {0} poginen nodig om het getal te vinden", trys));
                    }
                }
                if (!solved)
                {
                    Console.Clear();
                }

                Console.WriteLine("Druk op enter om verder te gaan");
                Console.ReadLine();
            }
        }
    }
}
