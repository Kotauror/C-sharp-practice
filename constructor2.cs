// using System;

// namespace MyApp 
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             Car car1, car2, car3;

//             car1 = new Car("red");
//             Console.WriteLine(car1.Describe());

//             car2 = new Car("black");
//             car3 = new Car ("hehe", "lolo");
//             Console.WriteLine(car2.Describe());
//             car2.ChangeColor();
//             Console.WriteLine(car2.Describe());
//         }
//     }

//     class Car 
//     {
//         string carColor; 

//         public Car() 
//         {
//             Console.WriteLine("Constructor with zero params");

//         }

//         public Car(string color) : this()
//         {
//             this.carColor = color;
//             Console.WriteLine("Constructor with color parameter called!");
//         }

//         public Car(string param1, string param2) : this(param1)
//         {
//             this.carColor = param1;
//             Console.WriteLine("Constructor with two parames called!");
//             Console.WriteLine(this.carColor);
//         }

//         public string Describe()
//         {
//             if(Color == "black")
//             return "I am not printing black cars";
//             else 
//             Console.WriteLine("This car is " + Color);
//             return "I've described, happy?";
//         }

//         public void ChangeColor() 
//         {
//             Color = "white";
//         }

//         public string Color 
//         {
//             get { return carColor.ToUpper(); }
//             set { 
//                 if(value == "Red")
//                      carColor = value; 
//                 else
//                     Console.WriteLine("This car can only be red!");
//                 }
//         }
//     }
// }
