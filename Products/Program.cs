using System;

namespace Products
{
    class Program
    {
        public delegate string WithParameter(string name1, string name2);

        public delegate void WithParameter? WithParameterWithParameter();

        public delegate void WithParameter2 WithParameterWithParameter2();

        public delegate void WithParameter2();

        static void Main(string[] args)
        {
            Program program = new Program();

            /*string withParameter = program.WithPParameterMetod("Вася", "Петя");
            
            withParameter += WithParameterStaticMetod("Максим", "Лето");
            withParameter -= WithParameterStaticMetod("Максим", "Лето");*/
            WithParameterWithParameter2 withParameterWithParameter2 = delegate { };
            WithParameterWithParameter += WithParameterStaticMetod;
            var result = WithParameterWithParameter?.Invoke("Вася", "Жора");

            Console.WriteLine(result);
            WithParameterWithParameter += program.WithPParameterMetod;

            Console.WriteLine(result);
            /*
            WithParameter2 withParameter2 = WithPParameterMetod2;
            withParameter2();
            withParameter2 += WithPParameterMetod3;
            withParameter2();
            withParameter2 -= WithPParameterMetod3;
            withParameter2();
            */


            Console.ReadLine();


            /*var pr1 = new Product(100, "pr1");
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
            productCardMagnit.AddProductCard(pr1);*/
        }

        public static string WithParameterStaticMetod(string name1, string name2)
        {
            Console.WriteLine($"Статика {name2}");
            return $"Лялялля {name1}";
        }

        public string WithPParameterMetod(string name1, string name2)
        {
            Console.WriteLine($"Динамика {name2}");
            return $"Тру {name1}";
        }

        public static void WithPParameterMetod2()
        {
            Console.WriteLine($"Динамика");
        }

        public static void WithPParameterMetod3()
        {
            Console.WriteLine($"Динамика2");
        }


        /*public static void NotifyPerekrestok(Product product)
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
        }*/
    }

    internal class WithParameterWithParameter2
    {
    }
}