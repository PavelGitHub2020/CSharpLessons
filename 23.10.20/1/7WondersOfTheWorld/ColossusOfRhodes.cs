using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class ColossusOfRhodes : DescriptionWonderWorld
    {
       public ColossusOfRhodes()
       {
            name = "Colossus of Rhodes";
            country = "Greece";
            age = 2280;
       }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Rhodes");

            Console.WriteLine("Arcitector - Hares");

            Console.WriteLine("Construction time - 280 BC");

            Console.WriteLine("Type - The statue");

            Console.WriteLine("height - 33 meters");
        }
    }
}
