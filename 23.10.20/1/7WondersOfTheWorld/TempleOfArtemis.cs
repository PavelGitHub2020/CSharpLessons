using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld 
{
    class TempleOfArtemis : DescriptionWonderWorld
    {
        public TempleOfArtemis()
        {
            name = "Temple of Artemis";
            country = "Turkey";
            age = 3500;
        }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Selychuk");

            Console.WriteLine("Arhitectors - Hersifron, Metagen");

            Console.WriteLine("Construction time - 450 BC");

            Console.WriteLine("Type - Temple");

            Console.WriteLine("Length - 115 meters");

            Console.WriteLine("Height - 46 meters");
        }
    }
}
