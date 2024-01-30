using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class Program
    {
        //Example about IF (conditional/control structure)
        //and relational operator
        static void Main(string[] args)
        {
            Console.Write("Enter your grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            //We can omit (ignore) the bracket { } after if and else
            //if there is only 1 statement inside. But from 2 statements
            //you must include the bracket (compulsory).

            //Simple case: Pass (>=5) and Fail (<5)
            //if (grade >= 5.0) {  
            //    Console.WriteLine("Result: Pass");
            //    Console.WriteLine("Congratulation !");
            //} else { 
            //    Console.WriteLine("Result: Fail");
            //    Console.WriteLine("Good luck next time !");
            //}

            //Complicated case: 
            //9 - 10 : Excellent (IF)
            //8 - 9  : Very good (ELSE IF)
            //7 - 8  : Good (ELSE IF)
            //6 - 7  : Fair (ELSE IF)
            //5 - 6  : Pass (ELSE IF)
            //0 - 5  : Fail (ELSE IF)
            //<0 or >10 : Invalid grade (ELSE)

            if (grade >= 9.0 && grade <= 10)
                Console.WriteLine("Excellent");
            else if (grade >= 8.0 && grade < 9.0)
                Console.WriteLine("Very good");
            else if (grade >= 7.0 && grade < 8.0)
                Console.WriteLine("Good");
            else if (grade >= 6.0 && grade < 7.0)
                Console.WriteLine("Fair");
            else if (grade >= 5.0 && grade < 6.0)
                Console.WriteLine("Pass");
            else if (grade >= 0 && grade < 5.0)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Invalid grade");
        }
    }
}
