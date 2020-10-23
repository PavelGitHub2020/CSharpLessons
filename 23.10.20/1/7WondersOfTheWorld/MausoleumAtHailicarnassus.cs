using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class MausoleumAtHailicarnassus : DescriptionWonderWorld
    {
        public MausoleumAtHailicarnassus()
        {
            name = "Mausoleu at Hailicarnassus";
            country = "Turkey";
            age = 2500;
        }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Bodrum");

            Console.WriteLine("Arcitector - Satiros");

            Console.WriteLine("Construction time - 400 BC");

            Console.WriteLine("Type - Mausolemu");

            Console.WriteLine("Length - 45 meters");
        }
    }
}
