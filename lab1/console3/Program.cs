using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt user to input name (string)
            Console.Write("Enter your name: ");
            //get name from user (keyboard)
            String name = Console.ReadLine();
            //prompt user to input age (integer)
            Console.Write("Enter your age: ");
            //get name from user (keyboard)
            int age = Convert.ToInt32(Console.ReadLine());
            //display name & age to console (screen)
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old now");
            Console.WriteLine("You were born on " + (2024 - age));
        }
    }
}
