using System;
using System.Collections.Generic;
using System.Text;

namespace DistributionCompany
{

    enum Status1
    {
        HasCome,
        Implemented,
        Decommissioned,
        Transfered
    }
    public class Status
    {
        Status1 status1 = new Status1();
        
        private int choise;

        public void GetStatus()
        {
            Console.WriteLine($"Select product status:");
            Console.WriteLine("1 - HasCome");
            Console.WriteLine("2 - Implemented");
            Console.WriteLine("3 - Decomissioned");
            Console.WriteLine("4 - Transfered");

            choise = int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    status1 = Status1.HasCome;
                    break;

                case 2:
                    status1 = Status1.Implemented;
                    break;

                case 3:
                    status1 = Status1.Decommissioned;
                    break;

                case 4:
                    status1 = Status1.Transfered;
                    break;

                default:
                    Console.WriteLine("Incorrect number!");
                    break;
            }
        }

        public void PrintStatus()
        {
            Console.WriteLine("The status of product - " + status1);
        }

    }
}
