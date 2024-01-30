using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Note: we must write codes inside Main method to execute program (application)

            //Display output
            Console.WriteLine("Programming Technology - INS3107");
            Console.WriteLine("International School - Vietnam National University");
            //Remember to include semicolon (;) at the end of each statement
            //Get input from user (keyboard)
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            int birthYear; //birth_year;
            /* We need to do type casting (format conversion)
            for any input not text such as number, date, ....
            */
            birthYear = Convert.ToInt32(Console.ReadLine());

            // addition symbol (+): string concatenation (combination/merge)
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You were born in " +  birthYear);


            //int currentYear = 2024;  //hard coding => do not use this way
            //Get the current year (using DateTime library)
            int currentYear = DateTime.Now.Year;
            //Calculate age based on current year and birth year 
            int age = currentYear - birthYear;
            Console.WriteLine("You are " + age + " years old now");

            //CTRL + F5 : run program
        }
    }
}
