using System;
using System.Collections.Generic;
using System.Linq;

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
            var curd = new Product(90, "Curd");

            var bananas = new Product(90, "Bananas");
            var apples = new Product(120, "Apples");
            var pears = new Product(200, "Pears");
            var orange = new Product(130, "Orange");

            var cucumbers = new Product(160, "Cucumbers");
            var tomatoes = new Product(200, "Tomatoes");
            var pepper = new Product(350, "Pepper");

            var milkProduct = new ProductCard(new List<Product>() { milk, cheese, curd });
            var fruits = new ProductCard(new List<Product>() { bananas, apples, pears, orange });
            var vegetables = new ProductCard(new List<Product>() { cucumbers, tomatoes, pepper });

            var listCard = new List<ProductCard> { milkProduct, fruits, vegetables };


            // Выбрать такие корзины,в которых сумма всех продуктов больше 100
            var a = listCard.Where(x => listCard.Sum(x=>x.Items));

            // Выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины
            // Посчитать сумму всех продуктов в рамках каждой корзины


            return;

            // Выбрать такие корзины, у которых более 4 продуктов 
            var cardMoreFourProducts = listCard.Where(x => x.Items.Count > 3)
                .SelectMany(x => x.Items)
                .ToList();
            
            // Выбрать такие продукты, у которых название длинее 5 символов и цена больше 60
            var productsTitleMore5AndPriceMore60 = listCard.SelectMany(x => x.Items)
                .Where(x => x.Price > 60 && x.Title.Length > 5)
                .ToList();
            
            // Выбрать продукты из всех корзин, у которых цена в интервале от 10 до 100
            var sumCardPrice = listCard.SelectMany(x => x.Items)
                .Where(x => x.Price > 10 && x.Price < 100)
                .ToList();

            // Посчитать сумму всех продуктов для всех корзин суммарно
            var sumAllPrice = listCard.SelectMany(x => x.Items)
                .Sum(x => x.Price);


            var card = new ProductCard(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit, obj => true);
            card.ProductAddedEvent += cardOnProductAddedEvent();
            ;
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
            Console.WriteLine($"Скидка составила {1M - sale:P}, итоговая сумма - {summOfSale}");
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