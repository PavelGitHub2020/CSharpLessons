using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class AlexandrianLightHouse : DescriptionWonderWorld
    {
       public AlexandrianLightHouse()
       {
            name = "Alexandriab LightHouse";
            country = "Egypt";
            age = 2300;
       }

        public override void Characteristics()
        {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + "years");

            Console.WriteLine("Location - Alexandriy");

            Console.WriteLine("Arcitector - Ptolemey 2");

            Console.WriteLine("Construction time - 280 BC");

            Console.WriteLine("Type - LightHouse");

            Console.WriteLine("Length - 90 meters");

            Console.WriteLine("height - 150 meters");
        }
    }
}
