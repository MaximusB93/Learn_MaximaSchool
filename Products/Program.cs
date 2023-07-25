using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

namespace Products
{
    public class Program
    {
        private static Localization _localization = new Localization();

        public static EventHandler<ProductAddEventArgs> cardOnProductAddedEvent()
        {
            return (sender, eventArgs) =>
            {
                var product = eventArgs.AddedProduct;
                Console.WriteLine($"Добавлен продукт - {product}");
            };
        }

        public static List<ProductCard> CreateProduct()
        {
            var milk = new Product(60, "item_milk");
            var cheese = new Product(75, "item_cheese");
            var curd = new Product(90, "item_curd");

            var bananas = new Product(90, "item_bananas");
            var apples = new Product(120, "item_apples");
            var pears = new Product(200, "item_pears");
            var orange = new Product(130, "item_orange");

            var cucumbers = new Product(160, "item_cucumbers");
            var tomatoes = new Product(200, "item_tomatoes");
            var pepper = new Product(350, "item_pepper");

            var milkProducts = new ProductCard(new List<Product>() { milk, cheese, curd }, "Молочная продукция");
            var fruits = new ProductCard(new List<Product>() { bananas, apples, pears, orange }, "Фрукты");
            var vegetables = new ProductCard(new List<Product>() { cucumbers, tomatoes, pepper }, "Овощи");

            List<ProductCard> listCards = new List<ProductCard> { milkProducts, fruits, vegetables };
            FilteringCard filteringCard = new FilteringCard(listCards);
            return listCards;
        }

        public static void Main()
        {
            _localization.ViewLocalization();

            var card = new ProductCard(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit, obj => true);
            card.ProductAddedEvent += cardOnProductAddedEvent();
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