using System;
using System.Collections.Generic;
using System.Text;

namespace _7WondersOfTheWorld
{
    class ControlMenu
    {
        private int choise;//выбор в меню
        private int choise1;//продолжать или нет
        public ControlMenu() { }
        public void MenuWondersWorld()
        {
            Console.WriteLine("We are have 7 wonders of the world, and if you want to see:");

            Console.WriteLine("Enter 1 - The Pyramid of Cheops");

            Console.WriteLine("Enter 2 - Temple of Artemis");

            Console.WriteLine("Enter 3 - Statue of Zeus");

            Console.WriteLine("Enter 4 - Mausoleum at hailicarnassus");

            Console.WriteLine("Enter 5 - Hanging gardens og Babylon");

            Console.WriteLine("Enter 6 - Colossus of Rhodes");

            Console.WriteLine("Enter 7 - Alexandrian LightHouse");

            do
            {
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        ThePyramidOfCheops thePyramidOfCheops = new ThePyramidOfCheops();
                        thePyramidOfCheops.Characteristics();
                        break;
                    case 2:
                        TempleOfArtemis templeOfArtemis = new TempleOfArtemis();
                        templeOfArtemis.Characteristics();
                        break;
                    case 3:
                        StatueOfZeus statueOfZeus = new StatueOfZeus();
                        statueOfZeus.Characteristics();
                        break;
                    case 4:
                        MausoleumAtHailicarnassus mausoleumAtHailicarnassus = new MausoleumAtHailicarnassus();
                        mausoleumAtHailicarnassus.Characteristics();
                        break;
                    case 5:
                        HangingGardensOfBabylon hangingGardensOfBabylon = new HangingGardensOfBabylon();
                        hangingGardensOfBabylon.Characteristics();
                        break;
                    case 6:
                        ColossusOfRhodes colossusOfRhodes = new ColossusOfRhodes();
                        colossusOfRhodes.Characteristics();
                        break;
                    case 7:
                        AlexandrianLightHouse alexandrianLightHouse = new AlexandrianLightHouse();
                        alexandrianLightHouse.Characteristics();
                        break;
                    default:
                        Console.WriteLine("Dosen't exists wonder under this number, from 1 to 7");
                        break;
                }

                Console.WriteLine("Do you wand to continue? 1 - yes");
                choise1 = int.Parse(Console.ReadLine());

            } while (choise1 == 1);
           
        }

    }
}
