using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Customer:User
    {
        public double Balance { get; set; }
        public Customer(string name, string email, double balance)
            : base(name, email)
        {
            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative");
            }
            else
            {
                Balance = balance;
            }
        }
    }
}
