using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Products.Discounts;

namespace Products
{
    public class ProductCart : IEnumerable
    {
        public IDiscounts _discounts { get; set; }
        public List<Product> Products { get; }
        public List<ProductCart> ListCard { get; }
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

        public ProductCart(Action<Product> notifyAdddedProduct, Action<decimal, decimal> nitifyOfSalePercent,
            Func<decimal, decimal> calculateSaleFunc, Predicate<decimal> presentGift)
        {
            Products = new List<Product>();
            _notifyAdddedProduct = notifyAdddedProduct;
            _nitifyOfSalePercent = nitifyOfSalePercent;
            _calculateSaleFunc = calculateSaleFunc;
            _presentGift = presentGift;
        }

        public ProductCart(List<Product> products, string categoryName)
        {
            Products = products;
            CategoryName = categoryName;
        }
        
        public ProductCart(List<Product> products, IDiscounts discounts)
        {
            Products = products;
            _discounts = discounts;
        }

        public ProductCart(List<ProductCart> listCard)
        {
            ListCard = listCard;
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


        // public void GetSumCart()
        // {
        //     var aaa = ListCard.Select(x => x.Products.Sum(x => x.Price)).ToList();
        //     foreach (var product in ListCard)
        //     {
        //         product.Products.Sum(x => x.Price);
        //     }
        //
        //     for (int i = 0; i < UPPER; i++)
        //     {
        //         
        //     }
        // }

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

        public decimal CalculatorDiscounts(decimal sum, int countProduct)
        {
            return _discounts.CalculatorDiscounts(sum, countProduct);
        }
    }
}