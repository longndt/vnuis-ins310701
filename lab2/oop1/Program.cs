using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    //Program.cs
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new Student objects (class instances)
            Student s1 = new Student(12345, "Tuan Hung", "Cau Giay");
            Student s2 = new Student(88888, "Hung Lam", "Nam Tu Liem");

            //display name of student s1
            Console.WriteLine("Name of student s1: " + s1.getName());

            //display current address of student s1
            Console.WriteLine("Current address of student s1: " + s1.getAddress());

            //change address of student s1
            s1.setAddress("Ha Dong");

            //display new address of student s1
            Console.WriteLine("New address of student s1: " + s1.getAddress());

            //display all information of student s2
            s2.displayInfo();
        }
    }
}
