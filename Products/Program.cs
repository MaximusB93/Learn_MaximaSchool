using System;
using System.Collections.Generic;

namespace Products
{
    class Program
    {
        public static EventHandler<ProductAddEventArgs> cardOnProductAddedEvent()
        {
            return (sender, eventArgs) =>
            {
                var product = eventArgs.AddedProduct;
                Console.WriteLine($"Добавлен продукт - {product}");
            };
        }

        static void Main()
        {
            var milk = new Product(60, "Milk");
            var cheese = new Product(75, "Cheese");
            var curd = new Product(75, "Curd");

            var bananas = new Product(75, "Bananas");
            var apples = new Product(75, "Apples");
            var pears = new Product(75, "Pears");
            
            var cucumbers = new Product(75, "cucumbers");
            var tomatoes = new Product(75, "tomatoes");
            var pepper = new Product(75, "Pepper");
            
            /*Dairy products
            fruits
                vegetables*/
                    
            var dairyProducts = new ProductCard(new List<Product>(){milk, cheese, curd});
            
            var card = new ProductCard(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit, obj => true);
            card.ProductAddedEvent += cardOnProductAddedEvent(); ;
            /*card.AddProducts(new []{pr1,pr2,pr3});*/
            card.ProductAddedEvent -= cardOnProductAddedEvent();

        }


        public static void NotifyPerekrestok(Product product)
        {
            Console.WriteLine($"Added new product: {product}");
        }

        public static void NotifyDiksi(Product product)
        {
            Console.WriteLine($"Diksi! Added new product: {product}");
        }

        public static void NotifyMagnit(Product product)
        {
            Console.WriteLine($"Magnit! Added new product: {product}");
        }

        public static void NotifyOfSale(decimal sale, decimal summOfSale)
        {
            Console.WriteLine($"Скидка составила {1M -sale:P}, итоговая сумма - {summOfSale}");
        }

        public static decimal CalculateSaleMagnit(decimal summ)
        {
            decimal sale = 1;
            if (summ > 1000)
            {
                sale = 0.95m;
            }

            else if (summ > 100)
            {
                sale = 0.975m;
            }

            else if (summ > 25)
            {
                sale = 0.99m;
            }

            return sale;
        }

        public static decimal CalculateSalePerekrestok(decimal summ)
        {
            decimal sale = 0.9m;

            return sale;
        }
    }
}