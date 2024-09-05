using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassessApp
{
    internal class Car
    {
        // member variable
        // private keyword hides the variable from other classes
        //private string _model = "";
        private string _brand = "";
        private bool _isluxury;

        // Constructor
        public Car(string model, string brand, bool isluxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isluxury;
            Console.WriteLine($"An object of car model {Model} and brand {Brand} has been created");
            //Isluxury = isluxury;
        }

        // Property
        //public string Model { get => _model; set => _model = value; }
        // Model doesn't require a backing field cuz we aren't modifying the model of the car
        public string Model { get; set; }
        public string Brand {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition!";
                }
                else
                {
                    return _brand;
                }
            }  

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing bitch!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
                 
            }
        }

        public bool IsLuxury { get; set; }
        //public bool Isluxury { get => _isluxury; set => _isluxury = value; }

        public void IsDrive()
        {
            Console.WriteLine($"I am a {Model} and I\'m driving!");
        }
    }
}
