using System;

namespace _6
{
    class Program
    {
        //Описать структуру RequestItem содержащую поля:
        //товар, кол-во единиц товара

        struct RequestItem
        {
            private string product;
            private int numberOfProduct;

            public void CollectionInf()
            {
                Console.WriteLine("Enter the name of product:");
                product = Console.ReadLine();

                Console.WriteLine("Enter number of goods:");
                numberOfProduct = int.Parse(Console.ReadLine());
            }

            public void Print()
            {
                Console.WriteLine("Name of product: " + product);

                Console.WriteLine("Number of product: " + numberOfProduct);
            }
        }

        static void Main(string[] args)
        {
            RequestItem requestItem = new RequestItem();
            requestItem.CollectionInf();
            requestItem.Print();
        }
    }
}
