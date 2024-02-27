using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch case
            //usage: equal comparison for number and character

            int speed = 2;
            switch (speed)
            {
                //no bracket inside each case
                //last case is "default"  
                //must include "break" at the end
                //number : no quotation
                //character : single quotation
                case 1:  //if
                    Console.WriteLine("Fan's speed is 1");
                    break; //stop
                case 2:  //else if
                    Console.WriteLine("Fan's speed is 2");
                    break;
                case 3:  //else if
                    Console.WriteLine("Fan's speed is 3");
                    break;
                default: //else 
                    Console.WriteLine("Invalid speed");
                    break;
            }
        }
    }
}
