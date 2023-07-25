using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Products
{
    public class ThreadCard
    {
        public List<ProductCard> ListCard { get; }

        public ThreadCard(List<ProductCard> listCard)
        {
            ListCard = listCard;
        }


        public void CreateThreadCard()
        {
            Thread t1 = new Thread(() => GetSumCard(ListCard.Where(x => x.CategoryName == "Молочная продукция")
                .ToList(), "Молочная продукция"));
            Thread t2 = new Thread(() => GetSumCard(ListCard.Where(x => x.CategoryName == "Фрукты")
                .ToList(), "Фрукты"));
            Thread t3 = new Thread(() => GetSumCard(ListCard.Where(x => x.CategoryName == "Овощи")
                .ToList(), "Овощи"));

            t1.Name = "Молочная продукция";
            t2.Name = "Фрукты";
            t3.Name = "Овощи";
            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void GetSumCard(List<ProductCard> productCard, string categoryProduct)
        {
            int sum = 0;
            foreach (var product in productCard)
            {
                sum += product.Products.Sum(x => x.Price);
            }

            Console.WriteLine($"Сумма продуктов {categoryProduct} - {sum}");
        }
    }
}