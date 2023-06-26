using System;

namespace Products
{
    class Program
    {
        static void Main()
        {
            var pr1 = new Product(10000, "pr1");
            var pr2 = new Product(90, "pr2");
            var pr3 = new Product(75, "pr3");


            /*Console.WriteLine("Перекресток");
            var productCardPerekrestok = new ProductCard(NotifyPerekrestok, NotifyOfSale, CalculateSaleMagnit);
            productCardPerekrestok.AddProductCard(pr1);
            productCardPerekrestok.AddProductCard(pr2);
            productCardPerekrestok.AddProductCard(pr3);
            productCardPerekrestok.GetTotalSumm();

            Console.WriteLine("Дикси");
            var productCardDiksi = new ProductCard(NotifyDiksi, NotifyOfSale, CalculateSaleMagnit);
            productCardDiksi.AddProductCard(pr1);
            productCardDiksi.AddProductCard(pr2);
            productCardDiksi.AddProductCard(pr3);

            Console.WriteLine("Магнит");
            var productCardMagnit = new ProductCard(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit);
            productCardMagnit.AddProductCard(pr1);*/
            Console.WriteLine("Перекресток");
            var card1 = new ProductCard(NotifyPerekrestok, 
                NotifyOfSale, 
                arg => { return 0.9m; },
                summ =>
                {
                    if (summ > 1000) return true;
                    return false;
                });

            card1.AddProductCard(pr1);
            card1.GetTotalSumm();
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