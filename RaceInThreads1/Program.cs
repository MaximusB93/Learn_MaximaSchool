using System;
using System.Threading.Tasks;

namespace RaceInThreads1
{
    class Program
    {
        private static int x = 0;
        private static object _sync = new object();

        static void Main(string[] args)
        {
            var TaskIncrement = Task.Factory.StartNew(() =>
            {
                lock (_sync)
                {
                    while (true)
                    {
                        x++;
                    }
                }
            });

            var TaskCheck = Task.Factory.StartNew(() =>
            {
                lock (_sync)
                {
                    while (x % 2 == 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            });
        }
    }
}