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
            //create new object and set initial university value
            GradeBook gb = new GradeBook("HUST");

            //add specific data => hard coding => not flexible
            //gb.Name = "David";
            //gb.Grade = 7.4;

            //get data from keyboard => more convenient for user
            Console.Write("Enter new university name: ");
            gb.setUniversityName(Console.ReadLine());
            Console.Write("Enter student's name: ");
            gb.Name = Console.ReadLine();
            Console.Write("Enter student's grade: ");
            //gb.Grade = Convert.ToDouble(Console.ReadLine());
            gb.Grade = Double.Parse(Console.ReadLine());
            Console.WriteLine("University: " + gb.getUniversityName());
            Console.WriteLine("Name: " + gb.Name);
            Console.WriteLine("Grade: " + gb.Grade);
        }
    }
}
