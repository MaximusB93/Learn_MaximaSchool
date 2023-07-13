using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.XPath;

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
            //     ● Дано целое число K (> 0) и целочисленная последовательность A. Найти теоретико-множественную
            // разность двух фрагментов A: первый содержит все четные числа, а второй — все числа с порядковыми
            //     номерами, большими K. В полученной последовательности (не содержащей одинаковых элементов)
            // поменять порядок элементов на обратный.
            //     ● Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
            //     содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
            // последовательность по возрастанию.
            //     ● Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
            // последовательности включает следующие поля:
            //     <Фамилия> <Год поступления> <Номер школы>
            //     Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
            // этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
            //     абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
            // по возрастанию номеров школ.


            int K = 7;
            Random random = new Random();
            var a = Enumerable.Range(0, 10)
                .Select(x => random.Next(1, 50))
                .ToArray();


            IEnumerable aaa = a.Where(x => x % 2 == 0).ToArray();
            var bbb = aaa.Except(a.Skip(K + 1));


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

            var milkProduct = new ProductCard(new List<Product>() { milk, cheese, curd }, "Молочная продукция");
            var fruits = new ProductCard(new List<Product>() { bananas, apples, pears, orange }, "Фрукты");

            var linq = milkProduct.Products.Intersect(fruits.Products).ToList();
            var linq1 = milkProduct.Products.Except(fruits.Products).ToList();
            var linq2 = milkProduct.Products.Union(fruits.Products).ToList();
            var linq3 = milkProduct.Products.Concat(fruits.Products).ToList();
            var linq4 = milkProduct.Products.ElementAtOrDefault(5);

            var vegetables = new ProductCard(new List<Product>() { cucumbers, tomatoes, pepper }, "Овощи");

            var listCard = new List<ProductCard> { milkProduct, fruits, vegetables };

            var dictionary = listCard.ToDictionary(x => x.CategoryName, x => x.Products.Select(x => x.Title));
            var dictonary2 = new Dictionary<string, string>();
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Категория: {item.Key}");
                foreach (var name in item.Value)
                {
                    Console.WriteLine($"- {name}");

                    dictonary2.Add(item.ToString(), name);
                }

                Console.WriteLine();
            }

            var dic = listCard.Select(x => x.CategoryName)
                .ToList();


            var nameProductCard = listCard.Select(x => x.CategoryName)
                .ToList();


            var aaaa = listCard.SelectMany(x => x.Products)
                .ElementAtOrDefault(7);

            var prods = listCard.SelectMany(x => x.Products)
                .Where(x => x.Price > 50 && x.Price < 100)
                .OrderBy(x => x.Price)
                .Select(x => x.Title)
                .ToList();

            var prods2 = listCard.SelectMany(x => x.Products)
                .GroupBy(x => x.Price)
                .Select(x => new { Price = x.Key, Count = x.Count() })
                .ToList();

            var prods3 = listCard.SelectMany(x => x.Products)
                .ToList();


            return;


            // Выбрать такие корзины,в которых сумма всех продуктов больше 500
            var sumCardMore100 = listCard.Where(x => x.Products.Sum(x => x.Price) > 500)
                .ToList();

            // Выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины
            var productMaxPriceInCard = listCard.Select(x => x.Products.Max(x => x.Price))
                .ToList();

            // Посчитать сумму всех продуктов в рамках каждой корзины
            var sums = listCard.Select(x => x.Products.Sum(x => x.Price))
                .ToList();

            // Выбрать такие корзины, у которых более 4 продуктов 
            var cardMoreFourProducts = listCard.Where(x => x.Products.Count > 3)
                .SelectMany(x => x.Products)
                .ToList();

            // Выбрать такие продукты, у которых название длинее 5 символов и цена больше 60
            var productsTitleMore5AndPriceMore60 = listCard.SelectMany(x => x.Products)
                .Where(x => x.Price > 60 && x.Title.Length > 5)
                .ToList();

            // Выбрать продукты из всех корзин, у которых цена в интервале от 10 до 100
            var sumCardPrice = listCard.SelectMany(x => x.Products)
                .Where(x => x.Price > 10 && x.Price < 100)
                .ToList();

            // Посчитать сумму всех продуктов для всех корзин суммарно
            var sumAllPrice = listCard.SelectMany(x => x.Products)
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