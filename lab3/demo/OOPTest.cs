using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class OOPTest
    {
        public static void Main()
        {
            //declare new object (class instance) without constructor
            OOPDemo oop = new OOPDemo();

            //invoke (call) method
            //we can only invoke method by creating object first
            oop.sayHello();
            oop.showInfo();
        }
      
    }
}
