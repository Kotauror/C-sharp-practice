using System;

namespace MyApp 
{
    class Program 
    {
        static void Main(string[] args){
            string[] names = new string[1];
            names[0] = "John Doe";
            Console.WriteLine(names[names.Length-1]);
        }
    }
}