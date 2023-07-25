using System.Collections.Generic;

namespace Products
{
    public class Product
    {
        public int Price { get; }
        public string Title { get; }

        public Product(int price, string title)
        {
            Price = price;
            Title = title;
        }

        public Product(int price)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Title}: {Price:C0}";
        }
    }
}