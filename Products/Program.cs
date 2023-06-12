using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr1 = new Product(100, "pr1");
            var pr2 = new Product(90, "pr2");
            var pr3 = new Product(75, "pr3");


            Console.WriteLine("Перекресток");
            var productCardPerekrestok = new ProductCard(NotifyPerekrestok);
            productCardPerekrestok.AddProductCard(pr1);
            productCardPerekrestok.AddProductCard(pr2);
            productCardPerekrestok.AddProductCard(pr3);
            
            Console.WriteLine("Дикси");
            var productCardDiksi = new ProductCard(NotifyDiksi);
            productCardDiksi.AddProductCard(pr1);
            productCardDiksi.AddProductCard(pr2);
            productCardDiksi.AddProductCard(pr3);
        }

        public static void NotifyPerekrestok(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }

        public static void NotifyDiksi(Product product)
        {
            Console.WriteLine($"Welcome! Added new product: {product}");
        }
    }
}