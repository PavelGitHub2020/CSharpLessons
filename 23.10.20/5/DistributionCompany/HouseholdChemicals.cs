using System;
using System.Collections.Generic;
using System.Text;

namespace DistributionCompany
{
    class HouseholdChemicals : TypeOfProduct
    {
        public HouseholdChemicals(string name, double price, int quantity) : base(name, price, quantity) { }

        public new void Print()
        {
            base.Print();
        }
    }
}
