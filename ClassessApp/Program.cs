namespace ClassessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            Console.WriteLine($"Number of cars is: {Car.NumberOfCars}");
            


            Console.ReadKey();
        }
    }
}
