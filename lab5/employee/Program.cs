using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee("Tuan", 12345, (float)999.99);
            emp2.GiveBonus(100);
            //Console.WriteLine(emp2.empName); //error: Cannot access private member from outside class
            Console.WriteLine(emp2.GetName()); //solution: we use accesser to access that member
            emp2.DisplayStats();
        }
    }
}
