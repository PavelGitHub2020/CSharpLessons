using System;

namespace _7WondersOfTheWorld
{
    //Разработайте приложение 7 чудес света, где каждое чудо будет представленно 
    //отдельным классом, содержащий точку входа. Распределите приложение по файлам
    //проекта и с помощью пространства имен обеспечьте возможность взаимодействия классов.
    class Program
    {
        static void Main(string[] args)
        {
            ControlMenu controlMenu = new ControlMenu();
            controlMenu.MenuWondersWorld();
        }
    }
}
