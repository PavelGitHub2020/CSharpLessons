using System;
using System.Collections.Generic;
using System.Text;

namespace LessonTwo
{
    class Satellite
    {
        private double speed;
        private string name;
        private bool isFly;
        private bool IsBroadcast;
        private string message;

        public Satellite(string name, double speed, bool isFly, bool IsBroadcast, string message)
        {

            this.name = name;
            this.speed = speed;
            this.isFly = isFly;
            this.IsBroadcast = IsBroadcast;
            this.message = message;
        }

        public void GoToSpace()
        {
            Console.WriteLine("Go to space!");
        }

        public void GoLand()
        {
            Console.WriteLine("We are flying to the ground");
        }

        public void UpSpeed()
        {
            speed += 100;

            if (IsBroadcast)
            {
                Console.WriteLine("Speed increased and = {0}", speed);
            }
        }

        public void DownSpeed()
        {
            speed -= 100;

            if (IsBroadcast)
            {
                Console.WriteLine("Speed decreased and = {0}", speed);
            }
        }

        public void GetInfo()
        {
            Console.WriteLine("Satellite {0}", name);

            if (isFly)
            {
                Console.WriteLine("Flying with speed {0}", speed);
            }
            else
            {
                Console.WriteLine("Is currently on the ground");
            }

            if (IsBroadcast)
            {
                Console.WriteLine("Broadcast is on");
            }
            else
            {
                Console.WriteLine("Broadcast is of");
            }
        }

        public void ChangeMessage()
        {
            Console.WriteLine("Enter the message!");
            message = Console.ReadLine();
        }


        public void StartBroadcast()
        {
            if (IsBroadcast)
            {
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(message);
                    }

                } while (Console.ReadKey(true).Key != ConsoleKey.Enter);//останавливаем трансляцию по нажатию Enter
            }
        }

        public void EnableBroadcast()//можем сами выбирать, включить или выключить трансляцию уже после того, как спутник создан
        {
            Console.WriteLine("Do you want to enable broadcast? Enter 1 - yes, 0 - no");

            int choise = Convert.ToInt32(Console.ReadLine());

            if (choise == 1)
            {
                IsBroadcast = true;
                return;
            }
            else
            {
                IsBroadcast = false;
                Console.WriteLine("You chose not to include broadcast!");
            }

        }

        public void ControlMenu()
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine(
                        " 1 - Go to space" +
                        " 2 - Go land" +
                        " 3 - Up speed" +
                        " 4 - Down speed" +
                        " 5 - Get info" +
                        " 6 - Change message" +
                        " 7 - Start broadcast" +
                        " 8 - Enable broadcast" +
                        " 9 - Exit the menu");

                    int choise = Convert.ToInt32(Console.ReadLine());


                    switch (choise)
                    {
                        case 1: GoToSpace(); break;

                        case 2: GoLand(); break;

                        case 3: UpSpeed(); break;

                        case 4: DownSpeed(); break;

                        case 5: GetInfo(); break;

                        case 6: ChangeMessage(); break;

                        case 7: StartBroadcast(); break;

                        case 8: EnableBroadcast(); break;

                        case 9: return;

                        default:
                            Console.WriteLine("There is no such operation!");
                            break;
                    }

                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    };
}

