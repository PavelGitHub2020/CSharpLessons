using System;

namespace _4
{
    class Program
    {
        //Описать перечисление ArticleTYpe определяющее типы товаров,
        //и добавить соответсвующее поле в структуру Article.

        private enum ArticleTYpe
        {
            Alcohol,
            Dairy,
            Meat,
            Tobacco,
            Flour,
            BabyFood
        }


        //Описать структуру Article, содержащую следующие поля:
        //код товара, название товара, цену товара. А так же добавленное 
        //перечисление ArticleTYpe.

        struct Article
        {
            private ArticleTYpe articleTYpe;
            private string productCode;
            private string nameProduct;
            private double priceProduct;
            private int productType;


            public Article(string prCode, string nmProduct, double prProduct, int prType)
            {
                productCode = prCode;
                nameProduct = nmProduct;
                priceProduct = prProduct;
                productType = prType;

                articleTYpe = new ArticleTYpe();

                switch (productType)
                {
                    case 0:
                        articleTYpe = ArticleTYpe.Alcohol;
                        break;
                    case 1:
                        articleTYpe = ArticleTYpe.Dairy;
                        break;
                    case 2:
                        articleTYpe = ArticleTYpe.Meat;
                        break;
                    case 3:
                        articleTYpe = ArticleTYpe.Tobacco;
                        break;
                    case 4:
                        articleTYpe = ArticleTYpe.Flour;
                        break;
                    case 5:
                        articleTYpe = ArticleTYpe.BabyFood;
                        break;
                    default:
                        break;
                }
            }

            public void Print()
            {
                Console.WriteLine("Product code - " + productCode);
                Console.WriteLine("Name product - " + nameProduct);
                Console.WriteLine("Price product - " + priceProduct + "$");
                if (productType < 0 || productType > 5)
                {
                    Console.WriteLine("Type of product - there is no product type with this number! Only from 0 to 5");
                    return;
                }
                Console.WriteLine("Type of product - " + articleTYpe);
            }

        }

        static void Main(string[] args)
        {
            Article article = new Article("2CX-12", "Pasta", 32.5, 3);
            article.Print();
        }
    }
}
