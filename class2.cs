// using System;

// namespace MyApp 
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             Car car1, car2;

//             car1 = new Car("red");
//             Console.WriteLine(car1.Describe());

//             car2 = new Car("black");
//             Console.WriteLine(car2.Describe());
//             car2.ChangeColor();
//             Console.WriteLine(car2.Describe());
//         }
//     }

//     class Car 
//     {
//         string carColor; 

//         public Car(string color)
//         {
//             this.carColor = color;
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
