using System;

namespace MyApp
{
    public static class Squares
    {
        public static class Operation(num1, num2) 
        {
            return num1 * num2;
        } 
    }
}

Console.WriteLine(Squares.Operation(2, 4))
