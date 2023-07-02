using System;
using System.Reflection; 

namespace Products
{
    [Obsolete("Логика устарела")]
    public class Product
    {
        public int Price { get; }
        public string Title { get; set;}
        public bool IsNew { get; set; }

        public Product(int price, string title)
        {
            Price = price;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}: {Price:C0}";
        }

        protected bool Equals(Product other)
        {
            return Price == other.Price && Title == other.Title;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Product)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Price, Title);
        }
    }
}