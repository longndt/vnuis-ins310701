using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = 6;
            //if (grade >= 5)
            //    Console.WriteLine("Pass");
            //else
            //    Console.WriteLine("Fail");

            //new solution: use ternary operator to replace for "if else" structure
            //syntax : (condition) ? true : false
            string result = (grade >= 5) ? "Passed" : "Fail";
            Console.WriteLine(result);
        }
    }
}
