using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(PrintTimeAction);
            task.Start();

            while (true)
            {
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                
                Console.WriteLine(CalculateSum(a, b));
            }
        }

        private static void PrintTimeAction()
        {
            while (true)
            {
                Console.WriteLine($"{DateTime.Now:t}");
                Thread.Sleep(3000);
            }
        }

        private static int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}