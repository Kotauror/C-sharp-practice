using System;

namespace MyApp
{
    class Program 
    {
        static void Main(string[] args)
        {
           int number = 20;
           AddFive(number);
           Console.WriteLine(number);
           Console.ReadKey();

        }

        static void AddFive(int number)
        {
            number = number + 5;
        }
    }
}

// by value - we dont change the initial number = 20, only use a copy of its value.