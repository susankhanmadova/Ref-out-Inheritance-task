using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DerivedProductsPhone:Product
    {
        public string Brand { get; set; }
        public string Storage { get; set; }
        public DerivedProductsPhone(string name, double price, int stock, string brand,string storage)
            : base (name, price, stock)
        {
            Brand = brand;
            Storage = storage;
        }
    }
}
