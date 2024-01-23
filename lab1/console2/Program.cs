using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            int x = 10;
            int y = 5;
            int z = x + y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = x + y = " + z);
            /* In case 1 solution has many projects, we need to select default project (startup project) to run
             1st: Right click on project and select "Set as startup project"
             2nd: Select startup project from dropdown list (on left side of Start button)
            */
            double PI = 3.14; //PI number
            float grade = (float)7.5;
            //string uses with double quotes
            String vnu = "Vietnam National University";
            Console.WriteLine(vnu);
            //character uses with single quotes
            char c = 'a';
            bool pass = true; 
        }
    }
}
