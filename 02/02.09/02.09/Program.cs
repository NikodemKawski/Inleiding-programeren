using System;

namespace _02._09
{
    class Program
    {
        static void Main(string[] args)
        {
            int dag;
            double totaal, resultaat;

            Console.Write("Totaal: ");
            totaal = double.Parse(Console.ReadLine()); //300
            Console.Write("Dag: ");
            dag = int.Parse(Console.ReadLine()); //3

            double korting = 0;

            if (dag % 2 == 0)
            {
                //even dag
                korting = 10;
            }
            else
            {
                korting = 15;
            }
            if (dag<= 3)
            {
                //korting = korting +2,5
                korting += 2.5;
            }

            resultaat = totaal - (totaal * (korting / 100));

            Console.WriteLine($"Resultaat: {resultaat}");
            Console.ReadLine();
        }
    }
}
