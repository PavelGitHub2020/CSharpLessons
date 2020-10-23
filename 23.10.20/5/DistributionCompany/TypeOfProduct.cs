using System;
using System.Collections.Generic;
using System.Text;

namespace DistributionCompany
{
    class TypeOfProduct : Status
    {
        protected string name;
        protected double price;
        protected int quantity;

        Status status = new Status();
        public TypeOfProduct(string name, double price, int quantity)
        {
            Console.WriteLine(name);

            this.name = name;
            this.price = price;
            this.quantity = quantity;

            status.GetStatus();
        }

        public void Print()
        {
            Console.WriteLine("Product name - " + name);

            Console.WriteLine("Product price - " + price + "$");

            Console.WriteLine("Product quantity - " + quantity);

            status.PrintStatus();

            Console.WriteLine();
        }
    }
}
