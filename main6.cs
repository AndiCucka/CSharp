using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[2, 0]);

            Console.ReadLine();
        }
    }
}
