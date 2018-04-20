using System;

namespace MyApp 
{
    class Program 
    {
        static void Main(string[] args){
            string[] names = new string[2];
            names[0] = "John Doe";
            names[1] = "Jusia Kota";
            foreach(string name in names) 
            {
            Console.WriteLine(name);
            }
        }
    }
}