using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard
    {
        
        
        public List<Product> Items { get; }

        public delegate void NotifyAdddedProduct(Product product);

        private readonly NotifyAdddedProduct _notifyAdddedProduct;

        public ProductCard(NotifyAdddedProduct notifyAdddedProduct)
        {
            Items = new List<Product>();
            _notifyAdddedProduct = notifyAdddedProduct;
        }

        public void AddProductCard(Product product )
        {
            Items.Add(product);
            _notifyAdddedProduct(product);
        }
 
        public decimal GetTotalSumm()
        {
            decimal summ = 0;
            foreach (var product in Items)
            {
                summ += product.Price;
            }

            if (summ > 1000)
            {
                return summ * 095m;
            }

            if (summ > 100)
            {
                return summ * 0975m;
            }

            if (summ > 25)
            {
                return summ * 099m;
            }

            return summ;
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