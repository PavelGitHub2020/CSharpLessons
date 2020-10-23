using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DistributionCompany
{
    class Foods : TypeOfProduct
    {
        public Foods(string name, double price, int quantity) : base(name, price, quantity) { }
        

        public new void Print()
        {
            base.Print();
        }
    }
}
