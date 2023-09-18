using System.Collections.Generic;

namespace Products
{
    public class Product
    {
        public int Price { get; }
        public string Title { get; }
        // public string Category { get; }

        public Product(int price, string title)
        {
            Price = price;
            Title = title;
            // Category = category;
        }

        public override string ToString()
        {
            return $"{Title}: {Price:C0}";
        }
    }
}