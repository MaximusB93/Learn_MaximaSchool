using System;
using System.Reflection;

namespace Products
{
    [Obsolete("Логика устарела")]
    public class Product
    {
        public int Price { get; }
        public string Title { get; }

        public Product(int price, string title)
        {
            Price = price;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}: {Price:C0}";
        }
    }
}