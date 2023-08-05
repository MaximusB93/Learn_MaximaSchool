using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CancelTask
{
    class Program
    {
        private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        static void Main(string[] args)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Stopwatch stopwatch = new Stopwatch();
            var task1 = Task.Factory.StartNew(LongWork1, _cancellationTokenSource.Token);
            var task2 = Task.Factory.StartNew(LongWork2, _cancellationTokenSource.Token);
            var tasks = new Task<int>[2] { task1, task2 };
            int finishedIndex = Task.WaitAny(tasks);
            _cancellationTokenSource.Cancel(true);
            var result = tasks[finishedIndex];
            Console.WriteLine($"Result - {result.Result}. finished task index - {finishedIndex}");


            //Console.ReadLine();
        }


        private static int LongWork1()
        {
            Thread.Sleep(2000);
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Token.ThrowIfCancellationRequested();
            }

            return 5 + 4;
        }

        private static int LongWork2()
        {
            Thread.Sleep(5000);
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Token.ThrowIfCancellationRequested();
            }

            Console.WriteLine("Второй поток закончил работу");
            return 10;
        }
    }
}