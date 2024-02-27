using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop

            //task 1: display all numbers from 1 to 20
            //for (int i = 1; i <= 20; i++) 
            //    Console.WriteLine(i);

            //task 2A: display all even numbers from 1 to 20
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2  == 0)  //check for even 
            //        Console.WriteLine(i);
            //}   

            //task 2B: display all even numbers from 1 to 20
            for (int i = 1; i <= 20; i++)
            { 
                if (i % 2 == 1)  //check for odd
                {
                    continue; //skip
                }  
                Console.WriteLine(i);
            }

            //infinity loop 1
            //for (int i = 1;   ; i++) 
            //    Console.WriteLine(i);

            //infinity loop 2
            //for (int i = 1; i<=20; i--)
            //    Console.WriteLine(i);
        }
    }
}
