using System;

namespace MyApp 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Car car1, car2;

            car1 = new Car("Red");
            Console.WriteLine(car1.Describe());

            car2 = new Car("black");
            Console.WriteLine(car2.Describe());
        }
    }

    class Car 
    {
        string carColor; 

        public Car(string color)
        {
            this.carColor = color;
        }

        public string Describe()
        {
            if(Color == "black")
            return "I am not printing black cars";
            else 
            Console.WriteLine("This car is " + Color);
            return "I've described, happy?";
        }

        public string Color 
        {
            get { return carColor; }
            set { carColor = value; }
        }
    }
}