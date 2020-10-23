using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
   abstract class DescriptionWonderWorld
  {
        protected string name;
        protected string country;
        protected int age;

        public  DescriptionWonderWorld()
        {
            name = "name";
            country = "country";
            age = 0;
        }

         public virtual void Characteristics() { }
  }
}
