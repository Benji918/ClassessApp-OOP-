using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassessApp
{
    internal class Password
    {
        public string UserPassword
        {
            set;
            private get;
        }

        public void DisplayPassword()
        {
            Console.WriteLine($"This is the user\'s password: {UserPassword}");

        }
    }

 
}
