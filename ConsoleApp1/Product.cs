using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public void Method()
        {
           if ((Price < 0) || (Stock < 0))
           {
                Console.WriteLine("Price and Stock cannot be negative");
           }
           
        }
        
    }
}
