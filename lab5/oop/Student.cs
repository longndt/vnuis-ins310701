using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //Student.cs : OOP class
    internal class Student
    {
        //field datas : characteristics => variables
        private string name;
        public int age;


        //data members : behaviours     => methods
        //constructor
          //default constructor : empty/parameterless constructor
          //public Student() { }  
          /*Note: if we do not declare any constructor,
          C# will automatically create default one */ 

          //we can override default constructor to satisfy our requirement
          public Student()
            {
                name = "Nguyen Van Nam";  //default name
                age = 18;                 //default age
            }

          //custom constructor : parameterized constructor
          public Student(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

        //getter (observer): view data
        public string getName()
        {
            return name;
        }

        //setter (mutator) : change data
        public void setName(string name)
        {
            this.name = name;
        }

        //custom (user-defined) methods
        public void sayHello()
        {
            Console.WriteLine("Hello from a student !");
        }
        public void showStudentDetail()
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student age: " + age);
        }
    }
}
