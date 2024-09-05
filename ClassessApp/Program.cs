namespace ClassessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Customer instance
            /*Customer customer = new Customer(name:"Benjamin");
            Customer frank = new Customer(name: "Frank", address: "oddjdidjf", contactNumber:"08033473998");
            Customer JogDoe = new Customer();
            Console.WriteLine($"Name of customer is {customer.Name}");
            Console.WriteLine($"Name of customer is {frank.Name}");
            Console.WriteLine($"Name of customer is {JogDoe.Name}");*/

            Car Audi = new Car(brand: "Audi", isluxury: true, model: "I3");
            Audi.IsDrive();


            Console.ReadKey();
        }
    }
}
