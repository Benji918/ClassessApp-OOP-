using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassessApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Custructor
        public Customer()
        {
            Name = "DefaultName";
            Address = "No 4 Emene road";
            ContactNumber = "Unknown!";
        }

        // Custom Custructor
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Another custom construtor
        public Customer(string name)
        {
            Name = name;
        }

        // methods
        public void SetDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // static method
        public static void DoSomething()
        {
            Console.WriteLine("Hello there");
        }
    }

    
}
