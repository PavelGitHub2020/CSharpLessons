using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
   class ThePyramidOfCheops : DescriptionWonderWorld
   {
       public ThePyramidOfCheops()
       {
            name = "The Pyramid of Cheops";
            country = "Egypt";
            age = 4500;
       }

       public override void Characteristics()
       {
            Console.WriteLine("Name - " + name);

            Console.WriteLine("County - " + country);

            Console.WriteLine("Age - " + age + " years");

            Console.WriteLine("Location - Giza");

            Console.WriteLine("Customer - Cheops");

            Console.WriteLine("Construction time - 2600 BC");

            Console.WriteLine("Type - Pyramid");

            Console.WriteLine("Base size - 230 meters");

            Console.WriteLine("Height - 138,75 meters");
       }
   }
}
