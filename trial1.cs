using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args) 
        {
            int index = 0;
            while(index <= 5) {
                index++;

            switch(index) {
                case 1 :
                    Console.WriteLine("Jeremy");
                    break;

                case 2 :
                    Console.WriteLine("Andy");
                    break;

                case 3 :
                    Console.WriteLine("Luke");
                    break;
                
                case 4 :
                    Console.WriteLine("Hannah");
                    break;

                case 5 :
                    Console.WriteLine("Molly");
                    break;
            }

            }
        }
    }
}