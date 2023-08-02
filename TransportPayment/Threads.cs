using System;
using System.Threading;

namespace TransportPayment
{
    public class Threads
    {
        private static int _numberThreads = 2;
        Thread[] threads = new Thread[_numberThreads];

        public void StartThreads(Action method)
        {
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => method.Invoke());
                threads[i].Start();
            }
        }
    }
}