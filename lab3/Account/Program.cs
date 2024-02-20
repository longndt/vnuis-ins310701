using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter initial account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Account acc = new Account(balance);
            Console.WriteLine("Initial balance: " + "$" + acc.Balance);

            Console.Write("Enter deposit amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.deposit(amount);
            Console.WriteLine("Updated balance: " + "$" + acc.Balance);
        }
    }
}
