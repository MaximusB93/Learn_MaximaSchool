using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Products
{
    public class ThreadCart
    {
        public List<ProductCart> ListCart { get; }
        public decimal TotalSum = 0;
        public object lockObject = new object();

        public ThreadCart(List<ProductCart> listCart)
        {
            ListCart = listCart;
        }

        public void CalculateSum()
        {
            List<Thread> threads = new List<Thread>();
            int sum = 0;
            foreach (var productCart in ListCart)
            {
                Thread thread = new Thread(() => GetSumCart(productCart));
                thread.Name = productCart.CategoryName;
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
                thread.Join();
            
            Console.WriteLine($"Сумма всех продуктов во всех корзинах - {TotalSum}");
        }

        public void GetSumCart(ProductCart productCart)
        {
            decimal sum = 0;
            foreach (var product in productCart.Products)
                sum += product.Price;

            lock (lockObject)
                TotalSum += sum;

            Console.WriteLine($"Сумма продуктов корзины {productCart.CategoryName} - {sum}");
        }
    }
}