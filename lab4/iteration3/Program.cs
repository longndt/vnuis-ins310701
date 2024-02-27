using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do...while
            //main usage: input validation
            /* difference between "while" and  "do...while"
              "while" always check fors condition to run code inside structure
              "do...while" skip checking condition for first time 
              (no matter whether the condition is correct or incorrect
                => code inside "do" always run at first time)
            */
            double grade;
            do
            {
                Console.Write("Enter your grade (0-10): ");
                grade = Convert.ToDouble(Console.ReadLine());
            } while (grade < 0 || grade > 10);
            //inside while : wrong input range
            Console.WriteLine("Your grade is: " + grade);
        }
    }
}
