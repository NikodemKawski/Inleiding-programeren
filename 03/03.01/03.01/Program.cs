using System;

namespace _03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, cijfercode, resultaat;
            string lettercode;

            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            lettercode = Console.ReadLine().ToLower();
            cijfercode = int.Parse(Console.ReadLine());
            

            if (lettercode == "a")
            {
                if (cijfercode == 1)
                {
                    resultaat = getal1 + getal2;
                    Console.WriteLine("{0} + {1} = {2}", getal1, getal2, resultaat);
                }
                else if (cijfercode == 2)
                {
                    resultaat = getal2 + getal3;
                    Console.WriteLine("{0} + {1} = {2}", getal2, getal3, resultaat);
                }
                else
                {
                    resultaat = getal1 + getal3;
                    Console.WriteLine("{0} + {1} = {2}", getal1, getal3, resultaat);
                }
            }
            else if (lettercode == "b")
            {
                if (cijfercode == 1)
                {
                    resultaat = getal1 - getal2;
                    Console.WriteLine("{0} - {1} = {2}", getal1, getal2, resultaat);
                }
                else if (cijfercode == 2)
                {
                    resultaat = getal2 - getal3;
                    Console.WriteLine("{0} - {1} = {2}", getal2, getal3, resultaat);
                }
                else
                {
                    resultaat = getal1 - getal3;
                    Console.WriteLine("{0} - {1} = {2}", getal1, getal3, resultaat);
                }
            }
        }
    }
}
