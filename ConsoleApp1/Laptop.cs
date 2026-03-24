using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Laptop:Product
    {
        public int RAM { get; set; }
        public int Processor { get; set; }
        public Laptop(string name, double price, int stock, int ram, int processor)
            : base(name, price, stock)
        {
            RAM = ram;
            Processor = processor;
        }
    }
}
