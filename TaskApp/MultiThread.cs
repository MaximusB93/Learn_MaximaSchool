using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskApp
{
    public class MultiThread
    {
        private static int[] array = new[] { 11, 7, 8, 10, 5, 15 };

        public void Start()
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            Task[] tasksList = new Task [array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                tasksList[i] = Task.Factory.StartNew(() => CalculateFactorial(index));
            }

            Task.WaitAll(tasksList);
            time.Stop();

            Console.WriteLine();
            Console.WriteLine("Время выполнения многопоточки: " + time.ElapsedMilliseconds + " мс");
        }

        public  void CalculateFactorial(int i)
        {
            int result = 1;
            for (int y = 2; y < array[i] + 1; y++)
            {
                result *= y;
            }

            Console.WriteLine($"Факториал числа {array[i]} равен: {result}");
        }
    }
}