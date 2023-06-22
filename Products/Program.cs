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
            var productCardPerekrestok = new ProductCard(NotifyPerekrestok, (sale, summOfSale) => {Console.WriteLine($"Скидка составила {sale:P}, итоговая сумма - {summOfSale}");} );
            productCardPerekrestok.AddProductCard(pr1);
            productCardPerekrestok.AddProductCard(pr2);
            productCardPerekrestok.AddProductCard(pr3);
            productCardPerekrestok.GetTotalSumm();

            Console.WriteLine("Дикси");
            var productCardDiksi = new ProductCard(NotifyDiksi,NotifyOfSale);
            productCardDiksi.AddProductCard(pr1);
            productCardDiksi.AddProductCard(pr2);
            productCardDiksi.AddProductCard(pr3);

            Console.WriteLine("Магнит");
            var productCardMagnit = new ProductCard(NotifyMagnit,NotifyOfSale);
            productCardMagnit.AddProductCard(pr1);
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
            Console.WriteLine($"Скидка составила {sale:P}, итоговая сумма - {summOfSale}");
        }
    }
}