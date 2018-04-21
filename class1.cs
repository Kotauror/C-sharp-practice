// using System;

// namespace myApp 
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             Car car1, car2;

//             car1 = new Car("Green");
//             Console.WriteLine(car1.Describe());
//             car1.ChangeColor();
//             Console.WriteLine(car1.Describe());

//             car2 = new Car("Blue");
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
//             return "This car is " + Color;
//         }

//         public void ChangeColor() 
//         {
//             Color = "Black";
//         }

//         public string Color
//         {
//            get { return carColor; }
//            set { carColor = value; }
//         }
//     }
// }