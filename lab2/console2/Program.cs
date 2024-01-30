using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console2
{
    /*
     * 1. Prompt user to input two numbers 
     * 2. Calculate addition, subtraction, division, multiplication, remainder
     * 3. 
     * 3. Display the result
     *
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare necessary variables
            int a, b, addition, subtraction, division, multiplication, remainder;
            //input numbers from keyboard
            Console.Write("Enter first number: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt16(Console.ReadLine());
            //calculate the result
            addition = a + b;
            subtraction = a - b;
            division = a / b;
            multiplication = a * b;
            remainder = a % b;
            //display the result
            Console.WriteLine("a + b = " + a + " + " + b + " = " + addition);
            Console.WriteLine("a - b = " + a + " - " + b + " = " + subtraction);
            Console.WriteLine("a / b = " + a + " / " + b + " = " + division);
            Console.WriteLine("a * b = " + a + " * " + b + " = " + multiplication);
            Console.WriteLine("a % b = " + a + " % " + b + " = " + remainder);
        }
    }
}
