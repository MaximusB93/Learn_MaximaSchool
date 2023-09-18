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
        /*public static List<ProductCart> CreateProduct()
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

            var milkProducts = new ProductCart(new List<Product>() { milk, cheese, curd }, "Молочная продукция");
            var fruits = new ProductCart(new List<Product>() { bananas, apples, pears, orange }, "Фрукты");
            var vegetables = new ProductCart(new List<Product>() { cucumbers, tomatoes, pepper }, "Овощи");

            List<ProductCart> listCarts = new List<ProductCart> { milkProducts, fruits, vegetables };

            return listCarts;
        }*/
        public static List<ProductCart> CreateProduct;

        public static void Main()
        {
            ProductCart milkProducts =
                new ProductCart(new List<Product>() { StoreProducts.milk, StoreProducts.cheese, StoreProducts.curd }, new DiscountsQuantityProducts());
            decimal sum = milkProducts.Products.Sum(product => product.Price);
            int count = milkProducts.Products.Count;
            //milkProducts._discounts = new DiscountsQuantityProducts();
            var sum2 = milkProducts.CalculatorDiscounts(sum,count);
            Console.ReadLine();


//ThreadCart threadCart = new ThreadCart(CreateProduct());
//threadCart.CalculateSum();

// var card = new ProductCart(NotifyMagnit, NotifyOfSale, CalculateSaleMagnit, obj => true);
// card.ProductAddedEvent += cardOnProductAddedEvent();
// card.ProductAddedEvent -= cardOnProductAddedEvent();
        }
    }
}