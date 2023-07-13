using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Products;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var milkProduct = new List<Product>();

            foreach (var i in Enumerable.Range(1, 100))
            {
                milkProduct.Add(new Product(i, "Молоко"));
            }

            double sum = 0;
            double sum2 = 0;

            AutoResetEvent flag1 = new AutoResetEvent(false);
            AutoResetEvent flag2 = new AutoResetEvent(false);

            var thread = new Thread(o =>
            {
                sum = milkProduct.Take(milkProduct.Count / 2)
                    .Select(x => x.Price)
                    .Sum();
                flag1.Set();
            });
            var thread2 = new Thread(o =>
            {
                sum2 = milkProduct.TakeLast(milkProduct.Count / 2)
                    .Select(x => x.Price)
                    .Sum();
                flag2.Set();
            });

            thread.Start();
            thread2.Start();
            if (WaitHandle.WaitAll(new[] { flag1, flag2 }, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine($"{sum} + {sum2}");
                
            }
            else
            {
                Console.WriteLine("Не удалось");    
            }
        }

        private static void CreateMetodThread()
        {
            ThreadStart threadStart = new ThreadStart(Start1);
            var t1 = new Thread(threadStart);
            t1.Name = "Поток1";
            t1.Start();

            var t2 = new Thread(Start2);
            t2.Name = "Поток2";
            t2.Start();


            Console.ReadLine();
        }


        private static void Start1()
        {
            Console.WriteLine("Выполнен поток 1");
        }

        private static void Start2(object obj)
        {
            Console.WriteLine("Выполнен поток 2");
        }
    }
}