using System;

namespace _01._05
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, product;

            //read
            number1 = double.Parse(Console.ReadLine());

            //process
            product = (number1 * 9) / 5 + 32;

            //print
            Console.WriteLine($"Fahrenheit: {product}");

            Console.ReadLine();
        }
    }
}
