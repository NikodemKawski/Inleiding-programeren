using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> getallen = new List<int>();
        string input = "", getal = "", output = "";
        bool test;
        int number, laagste, hoogste;

        do
        {
            //Console.Write("Wil je een cijfer toevoegen? ");
            input = Console.ReadLine();
            while (input == "ja")
            {
                //Console.Write("Geef het cijfer: ");
                getal = Console.ReadLine();
                test = int.TryParse(getal, out number);
                getallen.Add(number);
                //Console.Write("Wil je een cijfer toevoegen? ");
                input = Console.ReadLine();
            }
        } while (String.IsNullOrWhiteSpace(input));

        laagste = getallen.Min();
        hoogste = getallen.Max();
        double avg = Queryable.Average(getallen.AsQueryable());

        output = $"Statistieken: \nLaagste cijfer: {laagste} \nHoogste cijfer: {hoogste} \nGemiddelde: {avg}";

        Console.Clear();
        Console.WriteLine(output);
    }
}