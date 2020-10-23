using System;
using System.Collections.Generic;
using System.Text;

namespace CountryComparison
{
    abstract class Comparison
    {
        protected int population;
        protected int men;
        protected int women;
        protected int retirees;
        protected int children;
        protected int disabled;

        public  void Population() 
        {
            Console.WriteLine("Population - " + population);
            Console.WriteLine("Men - " + men);
            Console.WriteLine("Women - " + women);
            Console.WriteLine("Retirees - " + retirees);
            Console.WriteLine("Children - " + children);
            Console.WriteLine("Disabled - " + disabled);
        }
    }
    
}
