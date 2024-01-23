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
            //1. Use CTRL + F5 (without debugging) to start program 
            Console.WriteLine("Hello world !");
            //2. Use F5 (with debugging) to start program along with ReadKey() method
            //Console.ReadKey();
            //single line comment for 1 code statement
            /*
             * multiple line comment for block of code or 1 class
             */
            //WriteLine(): write to screen then move to new line
            Console.WriteLine("International School - Vietnam National University");
            //Write: write to screen without moving to new line
            Console.Write("Programming Technology - INS3107");

            /*
             * IMPORTANT NOTES:
             * Code must be put inside Main() method to run
             * Every code statement must end with semicolon symbol (;) 
             */

            // Set the Text Color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n{0}\n{1}\n{2}", "Hanoi", "Vietnam", "Asia");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n{0}\n{1}\n{2}", "Singapore", "Singapore", "Asia");


        }
    }
}
