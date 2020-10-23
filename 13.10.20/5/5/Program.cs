using System;

namespace _5
{
    class Program
    {
        //Описать перечисление ClientType определяющее важность клиента,
        //и добавить соответствующее поле в структуру Client 

        private enum ClientType
        {
            Hypertym,
            Epileptoid,
            Hysteroyd,
            Schizoid,
            Asthenic
        }


        //Описать структуру Client содержащую поля:
        //код клиента, ФИО, адрес, телефон, кол-во заказов осуществленных
        //клиентом, сумма заказов клиента, перечисление ClientType


        struct Client
        {
            ClientType clientType;
            private int number;//номер типа клиента

            private int clientCode;
            private string surname;
            private string name;
            private string patronymic;
            private string addres;
            private string phoneNumber;
            private int ordersNumberClient;
            private int amountOfOrdersClient;


            public void PersonalData()
            {
                Console.WriteLine("Enter your surname:");
                surname = Console.ReadLine();

                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();

                Console.WriteLine("Enter your patronymic:");
                patronymic = Console.ReadLine();


                Random random = new Random();
                number = random.Next(0, 4);//якобы сотрудники сами определяют тип клиента, пока с ним разговаривают

                switch (number)
                {
                    case 0:
                        clientType = ClientType.Hypertym;
                        break;
                    case 1:
                        clientType = ClientType.Epileptoid;
                        break;
                    case 2:
                        clientType = ClientType.Hysteroyd;
                        break;
                    case 3:
                        clientType = ClientType.Schizoid;
                        break;
                    case 4:
                        clientType = ClientType.Asthenic;
                        break;
                    default:
                        break;
                }
            }

            public int PurchaseOFGoods()
            {
                Console.WriteLine("Enter client code:");

                clientCode = int.Parse(Console.ReadLine());

                return clientCode;
            }

            public void InformationForDelivery()
            {
                Console.WriteLine("Indicate your address:");
                addres = Console.ReadLine();

                Console.WriteLine("Indicate your phone number:");
                phoneNumber = Console.ReadLine();
            }

            public void QuantityAndSummOrders()
            {
                Random random = new Random();
                ordersNumberClient = random.Next(0, 10);

                if (ordersNumberClient == 0)
                {
                    amountOfOrdersClient = 0;
                    return;
                }

                amountOfOrdersClient = random.Next(10, 1000);
            }


            public void Print()
            {
                Console.WriteLine("Information about client:");

                Console.WriteLine("Surname - " + surname + " name - " + name + " patronymic " + patronymic);

                Console.WriteLine("Address - " + addres);

                Console.WriteLine("Phone number - " + phoneNumber);

                Console.WriteLine("Client code - " + clientCode);

                Console.WriteLine("Orders number client - " + ordersNumberClient);

                Console.WriteLine("Amount of orders client - " + amountOfOrdersClient);

                Console.WriteLine("Type of client - " + clientType);
            }

        }

        static void Main(string[] args)
        {
            Client client = new Client();
            client.PersonalData();
            client.InformationForDelivery();
            client.QuantityAndSummOrders();
            client.PurchaseOFGoods();
            client.Print();
        }
    }
}
