using System;
using System.Text;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a symbol: ");
            string symbol = Console.ReadLine();

            Console.Write("Enter a number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (symbol == "+")
            {
                Console.WriteLine(number + number2);
            }
            else if (symbol == "-")
            {
                Console.WriteLine(number - number2);
            }
            else if (symbol == "*")
            {
                Console.WriteLine(number * number2);
            }
            else if (symbol == "/")
            {
                Console.WriteLine(number / number2);
            }
            else
            {
                Console.WriteLine("Invalid symbol");
            }
        }
    }
}

