using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class StatueOfZeus : DescriptionWonderWorld
    {
        public StatueOfZeus()
        {
            name = "Statue of Zeus";
            country = "Greece";
            age = 2450;
        }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Olympiy");

            Console.WriteLine("Arcitector - Fidiy");

            Console.WriteLine("Construction time - 430 BC");

            Console.WriteLine("Type - Pyramid");

            Console.WriteLine("Length - 27 meters");

            Console.WriteLine("Height - 64 meters");
        }
    }
}
