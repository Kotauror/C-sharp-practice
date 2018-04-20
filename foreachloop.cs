using System;
using System.Collections;

namespace MyApp 
{
    class Program 
    {
        static void Main(string[] args)
       {
           ArrayList list = new ArrayList();
           list.Add("Kocia");
           list.Add("Psocia");

           foreach(string name in list)
               Console.WriteLine(name);
           
        }
    }
}
