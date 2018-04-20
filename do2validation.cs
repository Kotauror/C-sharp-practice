using System;

namespace MyApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            string input;

            do {
                Console.WriteLine("Please write cat");
                input = Console.ReadLine();
            } while( input != "cat");
                Console.WriteLine("Well!");
        }
    }
}