using System;

namespace MyApp 
{
    class Program 
    {
       static void Main(string[] args)
        {
            int numA = 4;
            int productA = Square(numA);
            Console.WriteLine(productA);

            int numB = 32;
            int productB = Square(numB);
            Console.WriteLine(productB);

            int productC = Square(12);
            Console.WriteLine(productC);

            int productD = Square(productA * 3);
            Console.WriteLine(productD);
        }

        static int Square(int i)
        {
            return i * i;
        }
    }

}