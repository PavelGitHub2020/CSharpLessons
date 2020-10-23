using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class HangingGardensOfBabylon : DescriptionWonderWorld
    {
        public HangingGardensOfBabylon()
        {
            name = "Hahging garden of Babylon";
            country = "iraq";
            age = 2600;
        }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Iraq");

            Console.WriteLine("Arcitector - Navuhodonosor2");

            Console.WriteLine("Construction time - 430 BC");

            Console.WriteLine("Type - Engineering structure");

            Console.WriteLine("Length - 120 meters");

            Console.WriteLine("height - 60 meters");
        }
    }
}
