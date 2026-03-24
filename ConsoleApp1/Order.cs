using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Order
    {
        public string Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double TotalPrice => Product.Price * Quantity;
        public Order(string customer, Product product, int quantity)
        {
            this.Customer = customer;
            this.Product = product;
            this.Quantity = quantity;
          
        }

           
            public void Methodd()
        {
                if (Quantity > 0 && Product.Stock >= Quantity)
                {

                    Product.Stock -= Quantity;
                    Console.WriteLine($"Product: {this.Product.Name}   Quantity: {this.Quantity}   Total Price: {TotalPrice}   Stock: {Product.Stock}"  );

                }
                else
                { Console.WriteLine("Not enough stock"); }
           
        }
    }
}
