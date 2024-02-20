using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //OOP (Object Oriented Programming) class
    internal class Mobile
    {
        //1. declare attributes/fields/properties with variables
        //Note: access modifier for variables must be "private" 
        //      => information hiding (security reason)
        private String brand;
        private String model;
        private double price;
        private int quantity;

        public String Color { get; set; }  //short-hand to declare getter & setter together

        //2. declare behaviours/operations with methods
        //constructor => to create new object (class instance)
        public Mobile() { }   //empty constructor
        public Mobile(string brand)    //"brand" in this statement is parameter not variable
        {
            this.brand = brand;   //"this" represent for class "Mobile" (current class)
        }
        public Mobile(string b, string m)
        {
            //we can ignore keyword "this" in this case because
            //left-side value (variable) != right-side value (parameter)
            brand = b;
            model = m;
        }
        public Mobile (string b, string m, double p, int q)   //complete constructor
        {
            brand = b;
            model = m;
            price = p;
            quantity = q;
        }
        //getter : observer => get value(s)
        public String getBrand()
        {
            return brand;
        }
        public String getModel()
        {
            return model;
        }

        //setter : mutator => change value(s)
        public void setPrice (double newPrice)
        {
            price = newPrice;   
        }

        //customized methods
        public void displayMobileDetail()
        {
            Console.WriteLine("Mobile brand: " + brand);
            Console.WriteLine("Mobile model: " + model);
            Console.WriteLine("Mobile price: " + price + "$");
            Console.WriteLine("Mobile quantity: " + quantity);
        }
    }
}
