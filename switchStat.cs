using System;

namespace myApp
{
    class Program 
     {

         static void Main(string[] args)
         {
             int number;

             Console.WriteLine("Please write a number");
             number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 0:
                    Console.WriteLine("The number is zero!");
                    break;
                case 1:
                    Console.WriteLine("The number is one!");
                    break;
                default: 
                    Console.WriteLine("The number not one or zero");
                    break;
            }
         }

     }
    
}