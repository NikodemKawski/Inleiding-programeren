using System;
using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> getallen = new List<int>();

        string invoer = " ";
        int getal, hoogste, laagste;
        bool test;
        string output = " ";

        do
        {
            //Console.WriteLine("Geef een cijfer: ");
            invoer = Console.ReadLine();
            test = int.TryParse(invoer, out getal);
            getallen.Add(getal);
        } while (!String.IsNullOrWhiteSpace(invoer));

        getallen.Sort();

        hoogste = getallen.First();
        laagste = getallen.Last();

        output = $"Laagste getal: {hoogste}\nHoogste getal: {laagste}";

        Console.WriteLine(output);
    }
}