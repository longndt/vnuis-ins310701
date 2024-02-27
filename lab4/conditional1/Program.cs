using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 185;

            //if (condition : logical expression) => true, else => false
            /*
             * if inside control structure, there is only statement
             * => no need to include the bracket { }
             * elsewise, if there are more than one statements
             * inside control structure
             * => we must include the bracket
             */

            //level 1: only if
            //if (grade >= 60) { 
            //    Console.WriteLine("Passed");
            //    Console.WriteLine("Congratulation !");
            //}

            //level 2: if + else
            //if (grade >= 60)
            //{
            //    Console.WriteLine("Passed");
            //    Console.WriteLine("Congratulation !");
            //}
            //else //grade < 60
            //        Console.WriteLine("Failed");
            //}

            //level 3 (nested if): if, else if, else
            //90 <= grade <= 100: excellent  => if
            //80 <= grade < 90 : good        => else if
            //70 <= grade < 80 : fair        => else if
            //50 <= grade < 70 : pass        => else if
            //0 <= grade < 50 : fail         => else if
            //grade < 0 or grade > 100 : invalid  => else

            //Ctrl + K & Ctrl + C : code comment
            //Ctrl + K & Ctrl + D : code format

            if (grade >= 90 && grade <= 100)
                Console.WriteLine("Excellent");
            else if (grade >= 80 && grade < 90)
                Console.WriteLine("Good");
            else if (grade >= 70 && grade < 80)
                Console.WriteLine("Fair");
            else if (grade >= 50 && grade < 70)
                Console.WriteLine("Pass");
            else if (grade >= 0 && grade < 50)
                Console.WriteLine("Fail");
            else   //grade < 0 or grade > 100
                Console.WriteLine("Invalid grade");
        }
    }
}
