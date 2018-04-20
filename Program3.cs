using System;

namespace App 
{
    class Program 
    {

        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Write a number from 0 to 10");
            number = int.Parse(Console.ReadLine());

            if(number > 10) 
                Console.WriteLine("It should be smaller than 10");
            else 
                if(number < 0)
                    Console.WriteLine("It should be bigger than 0");
                else 
                    Console.WriteLine("Good job");
            Console.ReadLine();
        }
    }
}