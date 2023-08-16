using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            
            for (int index = 0; index < luckyNumbers.Length; index++)
            {
                Console.WriteLine(luckyNumbers[index]);
            }
        }
    }
}