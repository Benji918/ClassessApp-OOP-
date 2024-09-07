using System;

namespace ClassessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            var car4 = new Car();
            Console.WriteLine($"Number of cars is: {Car.NumberOfCars}");

            var user = new Password();
            user.UserPassword = "fdfdf";
            user.DisplayPassword();
            Console.WriteLine(user.UserPassword);


            Console.ReadKey();
        }
    }
}
