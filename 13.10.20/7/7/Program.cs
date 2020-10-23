using System;

namespace _7
{
    class Program
    {
        //Описать перечисление PayType определяющее форму
        //оплаты клиентом заказа, и добавить соответствубщее
        //поле в структуру Request.

        private enum PayType
        {
            Cash,
            BankCard,
            EripSystem
        }


        //Описать структуру Request содержащую поля:
        //код заказа, клиент, дата заказов, перечень заказанных товаров,
        //сумма заказа(реализовать вычисляемым свойством), и перечисление PayType

        struct Request
        {
            private PayType payType;
            int select;//номер типа оплаты

            private int codeOrder;
            private string nameClient;
            private string[] listOFOrderedProducts;
            private double sumOrder;
            private int numberProduct;//переменная нужна для подсчета суммы заказа
            private int[] price;//переменная нужна для подсчета суммы заказа

            public void CollectionInf()
            {
                Console.WriteLine("Enter orders code:");
                codeOrder = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the name client:");
                nameClient = Console.ReadLine();

                do
                {
                    Console.WriteLine("Select payment type:");
                    select = int.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 0:
                            payType = PayType.Cash; break;
                        case 1:
                            payType = PayType.BankCard; break;
                        case 2:
                            payType = PayType.EripSystem; break;
                        default:
                            Console.WriteLine("There is no number this type payment! Try again  from 0 to 2");
                            break;
                    }
                } while (select < 0 || select > 2);
            }

            public void ListOFProducts()
            {
                Console.WriteLine("Enter number of products:");
                numberProduct = int.Parse(Console.ReadLine());

                listOFOrderedProducts = new string[numberProduct];

                for (int i = 0; i < numberProduct; i++)
                {
                    Console.WriteLine("Enter the name of product:");
                    listOFOrderedProducts[i] = Console.ReadLine();
                }
            }

            public void SumOfOrder()
            {
                Random random = new Random();

                price = new int[numberProduct];

                for (int i = 0; i < numberProduct; i++)
                {
                    price[i] = random.Next(5, 100);

                    sumOrder += price[i];
                }
            }

            public void Print()
            {
                Console.WriteLine("The name client - " + nameClient);

                Console.WriteLine("The code order - " + codeOrder);

                Console.WriteLine("Date order - " + DateTime.Now);//дата заказа идет как текущее время

                Console.WriteLine("You bought:");

                for (int i = 0; i < numberProduct; i++)
                {
                    Console.WriteLine(listOFOrderedProducts[i] + "\t" + price[i] + "$");
                }

                Console.WriteLine("Summ of order - " + sumOrder + "$");

                Console.WriteLine("Type payment - " + payType);
            }

        }


        static void Main(string[] args)
        {
            Request request = new Request();
            request.CollectionInf();
            request.ListOFProducts();
            request.SumOfOrder();
            request.Print();
        }
    }
}
