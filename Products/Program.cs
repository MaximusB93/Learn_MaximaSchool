using System;

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
            var pr1 = new Product(10000, "pr1");
            var pr2 = new Product(90, "pr2");
            var pr3 = new Product(75, "pr3");

            var card = new ProductCard(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit, obj => true);
            card.ProductAddedEvent += cardOnProductAddedEvent(); ;
            card.AddProducts(new []{pr1,pr2,pr3});
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