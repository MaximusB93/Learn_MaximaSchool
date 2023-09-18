using System.Collections.Generic;

namespace Products
{
    public class StoreProducts
    {
        /*List<Product> products = new List<Product>
        {
            new Product(60, "item_milk", "Молочная продукция"),
            new Product(75, "item_cheese", "Молочная продукция"),
            new Product(90, "item_curd", "Молочная продукция"),
            new Product(90, "item_bananas", "Фрукты"),
            new Product(120, "item_apples", "Фрукты"),
            new Product(200, "item_pears", "Фрукты"),
            new Product(130, "item_orange", "Фрукты"),
            new Product(160, "item_cucumbers", "Овощи"),
            new Product(200, "item_tomatoes", "Овощи"),
            new Product(350, "item_pepper", "Овощи")
        };*/


        public static Product milk => new Product(60, "item_milk") ;
        public static Product cheese => new Product(75, "item_cheese");
        public static Product curd => new Product(90, "item_curd");

        static Product bananas = new Product(90, "item_bananas");
        static Product apples = new Product(120, "item_apples");
        static Product pears = new Product(200, "item_pears");
        static Product orange = new Product(130, "item_orange");

        static Product cucumbers = new Product(160, "item_cucumbers");
        static Product tomatoes = new Product(200, "item_tomatoes");
        static Product pepper = new Product(350, "item_pepper");

        /*static ProductCart milkProducts = new ProductCart(new List<Product>() { milk, cheese, curd }, "Молочная продукция");
        static ProductCart fruits = new ProductCart(new List<Product>() { bananas, apples, pears, orange }, "Фрукты");
        static ProductCart vegetables = new ProductCart(new List<Product>() { cucumbers, tomatoes, pepper }, "Овощи");

        List<ProductCart> listCarts = new List<ProductCart> { milkProducts, fruits, vegetables };*/
    }
}