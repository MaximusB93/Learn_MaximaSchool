using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        private static object _sync = new object();

        static void Main(string[] args)
        {
            // var task = new Task(PrintTimeAction);
            // task.Start();
            //
            // Task.Factory.StartNew(PrintRandomNumber);
            //
            // Task.Run(PrintRandomNumber);

            // Parallel.Invoke(LongWork);
            var time = Stopwatch.StartNew();
            var task1 = Task<int>.Factory.StartNew(LongWork1).Result;
            var task2 = Task<int>.Factory.StartNew(LongWork2).Result;
            // Task.WaitAll(task1, task2);
            time.Stop();
            Console.WriteLine($"Cумма - {task1 + task2}, время - {time.ElapsedMilliseconds}");

            while (true)
            {
                Console.WriteLine("привет");
                Thread.Sleep(1000);
            }

            return;

            while (true)
            {
                Console.WriteLine("Введите числа");
                Console.ReadLine();
                lock (_sync)
                {
                    int a = Int32.Parse(Console.ReadLine());
                    int b = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(CalculateSum(a, b));
                }
            }
        }

        private static int LongWork1()
        {
            Thread.Sleep(2000);
            // Console.WriteLine("пока");
            return 10;
        }

        private static int LongWork2()
        {
            Thread.Sleep(5000);
            // Console.WriteLine("пока");
            return 50;
        }

        private static void PrintRandomNumber()
        {
            Random random = new Random();
            while (true)
            {
                lock (_sync)
                {
                    Console.WriteLine($"Random number is - {random.Next(10)}");
                }

                Thread.Sleep(1000);
            }
        }

        private static void PrintTimeAction()
        {
            while (true)
            {
                lock (_sync)
                {
                    Console.WriteLine($"{DateTime.Now:t}");
                }

                Thread.Sleep(3000);
            }
        }

        private static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}