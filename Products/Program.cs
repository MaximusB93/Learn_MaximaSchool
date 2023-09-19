using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.XPath;
using Products.Discounts;

namespace Products
{
    public class Program
    {
        public static ProductCart milkProducts =
            new ProductCart(
                new List<Product>()
                {
                    StoreProducts.milk, StoreProducts.cheese, StoreProducts.curd, StoreProducts.bananas,
                    StoreProducts.bananas
                }, new DiscountsQuantityProducts());

        public static decimal sum = milkProducts.Products.Sum(product => product.Price);
        public static decimal sum2 = milkProducts.Products.Sum(product => product.Price);
        public static int count = milkProducts.Products.Count;


        public static void Main()
        {
            //Суммирование скидок
            decimal sum = SummingDiscounts();
            Console.WriteLine(sum);

            //Смена скидочной стратегии
            sum = SingleDiscounts();
            Console.WriteLine(sum);
        }

        public static decimal SummingDiscounts()
        {
            sum = milkProducts.CalculatorDiscounts(sum, count);
            milkProducts._discounts = new DiscoutnsSumProduct();
            sum = milkProducts.CalculatorDiscounts(sum, count);
            return sum;
        }

        public static decimal SingleDiscounts()
        {
            decimal sumDiscount = milkProducts.CalculatorDiscounts(sum2, count);
            milkProducts._discounts = new DiscoutnsSumProduct();
            sumDiscount = milkProducts.CalculatorDiscounts(sum2, count);
            return sumDiscount;
        }
    }
}