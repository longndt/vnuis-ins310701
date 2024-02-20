using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class OOPDemo
    {
        //set default (initial) value for class fields
        private string country = "Vietnam";
        private string city = "Hanoi";

        public string Country { get; set; }
        public string City { get; set; }

        //no need to declare default constructor
        //(empty constructor)

        public void sayHello()
        {
            Console.WriteLine("Hello world");
        }

        public void showInfo()
        {
            Console.WriteLine("Country: " + country);
            Console.WriteLine("City: " + city);
        }
    }
}
