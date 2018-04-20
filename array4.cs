using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arrayOfThings = { 0, "kot", 2, "pies", 6, 3 };

            foreach(object stuff in arrayOfThings)
                Console.WriteLine(stuff);
       }
    }
}