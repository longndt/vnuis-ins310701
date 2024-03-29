﻿using EmployeeApp2;
using System;

namespace EmployeeApp2
{
    class MainClass
    {
        // Create a subclass object and access base class functionality.
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            // A better bonus system!
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
        }
    }
}
