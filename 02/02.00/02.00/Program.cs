using System;

namespace _02._00
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            string resultaat;

            //inlezen

            getal1 = int.Parse(Console.ReadLine());

            //bewerking uitvoeren

            if (getal1 >= 0)
            {
                resultaat = "Positief";
            }
            else
            {
                resultaat = "Negatief";
            }

            //resultaat tonen
            Console.WriteLine("\n\t{0}", resultaat);

        }
    }
}
