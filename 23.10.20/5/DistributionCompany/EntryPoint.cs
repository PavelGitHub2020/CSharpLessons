using System;

namespace DistributionCompany
{
    //Разработать архитектуру классов иерархии товаров при разработке
    //системы управления потоками товаров для дистрибьюторской компании.
    //Прописать члены классов. 
    //Должны быть предусмотрены разные типы товаров, в том числе:
    //бытовая химия
    //продукты питания
    //Предусмотреть классы управления потоком товаров
    //(пришло, реализовано, списано, передано).
    class EntryPoint
    {
        static void Main(string[] args)
        {

            TypeOfProduct[] typeOfProduct =
            {  
                new Foods("Milk", 10.4, 19),

                new ConstructionsMaterials("Nails", 12.3, 200),

                new Foods("Pasts", 4.3, 20),

                new HouseholdChemicals("Shampoo", 17.2, 45),

                new ConstructionsMaterials("Boards", 320.9, 1000),

                new HouseholdChemicals("Soap", 3.1, 80)
            };

            for(int i = 0; i < typeOfProduct.Length; i++)
            {
                typeOfProduct[i].Print();
            }
        }
    }
}
