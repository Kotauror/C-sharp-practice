using System;

namespace MyApp 
{
    class Program 
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];

            names[0] = "kot psot";
            names[1] = "mis pys";

            for(int i = 0; i < names.Length; i++)
            Console.WriteLine("item " + i + " " + names[i]);
        }
    }
}