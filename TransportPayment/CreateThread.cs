using System;
using System.Threading;

namespace TransportPayment
{
    public class CreateThread
    {
        Thread[] threads = new Thread[2];

        public void StartingThreads(Action metod)
        {
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(() => metod.Invoke());
                threads[i].Start();
            }
        }
    }
}