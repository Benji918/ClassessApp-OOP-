namespace ClassessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Created instance of class car
            Car audi  = new Car("i8", "audi", false);
            Car benz = new Car("E class", "benz", true);

            // Using the Car property
            // Settting brand
            Console.WriteLine("Enter car brand please");
            audi.Brand = Console.ReadLine();

            // Getting brand name
            Console.WriteLine($"Audi car brand is {audi.Brand}");
            Console.WriteLine($"Audi car brand is {benz.Brand}");
            Console.ReadKey();
        }
    }
}
