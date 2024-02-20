using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook
{
    internal class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook gb = new GradeBook();
            
            //add specific data => hard coding => not flexible
            //gb.Name = "David";
            //gb.Grade = 7.4;

            //get data from keyboard => more convenient for user
            Console.Write("Enter student's name: ");
            gb.Name = Console.ReadLine();
            Console.Write("Enter student's grade: ");
            //gb.Grade = Convert.ToDouble(Console.ReadLine());
            gb.Grade = Double.Parse(Console.ReadLine());    
            Console.WriteLine("Name: " + gb.Name);
            Console.WriteLine("Grade: " + gb.Grade);
        }
    }
}
