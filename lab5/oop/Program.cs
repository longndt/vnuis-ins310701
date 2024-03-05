using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //Program.cs : Test class
    internal class Program
    {
        static void Main(string[] args)
        {
            //object: class instance
            //create new student objects
            //create student1 with default constructor
            Student student1 = new Student();
            //create student2 with parameterized constructor
            Student student2 = new Student("Minh",20);

            //invoke (call) method from OOP class
            student1.sayHello();
            Console.WriteLine("Current name: " + student2.getName());
            student2.setName("Hoang"); //set new name for student2
            Console.WriteLine("New name: " + student2.getName());

            //Console.WriteLine(student2.name);  //incorrect: name is private => can not be accessed outside class
            Console.WriteLine(student2.age);   //correct: age is public => can be accessed anywhere

            Console.WriteLine("Student 1");
            student1.showStudentDetail();
            Console.WriteLine("Student 2");
            student2.showStudentDetail();
        }
    }
}
