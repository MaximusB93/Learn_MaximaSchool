using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr1 = new Product(100,"pr1");
            var pr2 = new Product(100,"pr2");
            var pr3 = new Product(100,"pr3");
            
            var productCard = new ProductCard();
            productCard.AddProductCard(pr1);
            productCard.AddProductCard(pr2);
            productCard.AddProductCard(pr3);

            Console.WriteLine(productCard.PrintAllProducts());
            
        }
    }
}