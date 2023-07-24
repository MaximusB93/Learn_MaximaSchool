using System;
using System.Collections.Generic;
using System.Threading;

namespace Lock
{
    class Program
    {
        private static object _sync = new object();
        private static List<int> _list = new List<int>();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(ReadDelegate) { Name = "Read1" };
            Thread t2 = new Thread(ReadDelegate) { Name = "Read2" };
            Thread t3 = new Thread(ReadDelegate) { Name = "Read3" };

            Thread t4 = new Thread(WriteDelegate) { Name = "Write1" };

            t1.Start();
            t2.Start();
            t3.Start();

            t4.Start();

            Console.ReadLine();
        }

        private static void ReadDelegate()
        {
            while (true)
            {
                lock (_sync)
                {
                    foreach (var item in _list)
                    {
                        Console.Write(item);
                    }
                }

                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }
        }

        private static void WriteDelegate()
        {
            while (true)
            {
                lock (_sync)
                {
                    _list.Add(1);
                }

                Thread.Sleep(TimeSpan.FromMilliseconds(100));
            }
        }
    }
}