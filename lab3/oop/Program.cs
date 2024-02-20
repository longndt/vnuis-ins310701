using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //Program class which includes "Main" method
    //used to run (execute) the C# program
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new object instance for Mobile
            Mobile mobile1 = new Mobile();
            mobile1.Color = "Black";  //setter

            Mobile mobile2 = new Mobile("Apple");
            Mobile mobile3 = new Mobile("Apple", "iPhone 15");
            Mobile mobile4 = new Mobile("Samsung", "Galaxy S23 Ultra", 1234.56, 50);

            //display output to console
            Console.WriteLine("Color of mobile 1: " + mobile1.Color); //getter
            Console.WriteLine("Brand of mobile 2: " + mobile2.getBrand());
            Console.WriteLine("Model of mobile 3: " + mobile3.getModel());
            Console.WriteLine("Set new price for mobile 4");
            mobile4.setPrice(999.99);
            Console.WriteLine("Mobile 4 detail: ");
            mobile4.displayMobileDetail();
        }
    }
}
