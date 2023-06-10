using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard
    {
        public List<Product> Items { get; }

        public ProductCard()
        {
            Items = new List<Product>();
        }

        public void AddProductCard(Product product)
        {
            Items.Add(product);
        }

        public string PrintAllProducts()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in Items)
            {
                stringBuilder.AppendLine(product.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}