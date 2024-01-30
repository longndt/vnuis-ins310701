using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    //OOP (Object Oriented Programming) class
    //Student.cs
    internal class Student
    {
        //1. attributes (variables)
        //Note: never set access modifier
        //of the variables to be "public"
        //it must be "private"
        //=> rule violation for "information hiding"
        private int Id;
        private string Name;
        private string Address;
       

        //2. behaviours (methods)
        //2.1 constructor
        public Student() { }  //empty constructor
        public Student(int Id, string Name, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            //=> We must use "this" keyword in this case to distinguise between left and right values.
            //They have similar name. Left is variable and Right is parameter
        }
        //public Student (int i, string n, string a)
        //{
        //    Id = i;
        //    Name = n;
        //    Address = a;
        //    => We do not need to use "this" keyword because left and right values are different name.
        //}
 
        //2.2 getter (observer)
        public int getId()
        {
            return Id;
        }

        public string getName()
        {
            return Name;
        }

        public string getAddress()
        {
            return Address;
        }

        //2.3 setter (mutator)
        public void setAddress (string Address)
        {
            this.Address = Address;
        }

        //2.4 extra methods
        //2.4.1 display student information
        public void displayInfo()
        {
            Console.WriteLine("Id: " + this.Id);  //this: optional in this case
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Address: " + this.Address);
        }
    }
}
