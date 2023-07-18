using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductCard : IEnumerable
    {
        public List<Product> Products { get; }
        public string CategoryName { get; }


        private readonly Action<Product> _notifyAdddedProduct;

        private readonly Action<decimal, decimal> _nitifyOfSalePercent;
        private readonly Func<decimal, decimal> _calculateSaleFunc;
        private readonly Predicate<decimal> _presentGift;

        public event EventHandler<ProductAddEventArgs> ProductAddedEvent;

        public void OnProductAddedEvent(Product addedProduct)
        {
            ProductAddedEvent?.Invoke(this, new ProductAddEventArgs(addedProduct));
        }


        public ProductCard(Action<Product> notifyAdddedProduct, Action<decimal, decimal> nitifyOfSalePercent,
            Func<decimal, decimal> calculateSaleFunc, Predicate<decimal> presentGift)
        {
            Products = new List<Product>();
            _notifyAdddedProduct = notifyAdddedProduct;
            _nitifyOfSalePercent = nitifyOfSalePercent;
            _calculateSaleFunc = calculateSaleFunc;
            _presentGift = presentGift;
        }

        public ProductCard(List<Product> products, string categoryName)
        {
            Products = products;
            CategoryName = categoryName;
        }

        public void AddProductCard(Product product)
        {
            Products.Add(product);
            OnProductAddedEvent(product);
            _notifyAdddedProduct(product);
        }

        public void AddProducts(params Product[] products)
        {
            foreach (var product in products)
            {
                AddProductCard(product);
            }
        }


        public void GetTotalSumm()
        {
            decimal summ = 0;
            decimal sale = 1M;
            foreach (var product in Products)
            {
                summ += product.Price;
            }

            if (_presentGift(summ))
            {
                Console.WriteLine("Вам подарок");
            }

            sale = _calculateSaleFunc(summ);
            decimal summOfSale = summ - summ * (1m - sale);

            _nitifyOfSalePercent(sale, summOfSale);
        }

        public string PrintAllProducts()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var product in Products)
            {
                stringBuilder.AppendLine(product.ToString());
            }

            return stringBuilder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}