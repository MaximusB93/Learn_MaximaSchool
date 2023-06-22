using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard
    {
        public List<Product> Items { get; }

        //public delegate void NotifyAdddedProduct(Product product);

        //public delegate void NitifyOfSalePercent(decimal sale, decimal summOfSale);
        
        

        private readonly Action<Product> _notifyAdddedProduct;
        private readonly Func<decimal,decimal> _nitifyOfSalePercent;

        public ProductCard(Action<Product> notifyAdddedProduct, Func<decimal,decimal> nitifyOfSalePercent)
        {
            Items = new List<Product>();
            _notifyAdddedProduct = notifyAdddedProduct;
            _nitifyOfSalePercent = nitifyOfSalePercent;
        }

        public void AddProductCard(Product product)
        {
            Items.Add(product);
            _notifyAdddedProduct(product);
        }

        public decimal GetTotalSumm()
        {
            decimal summ = 0;
            decimal sale = 1M;
            foreach (var product in Items)
            {
                summ += product.Price;
            }

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

            _nitifyOfSalePercent(1M - sale, summ-summ*(1m-sale));
            
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