using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskApp
{
    public class SingleThread
    {
        private static int[] array = new[] { 11, 7, 8, 10, 5, 15 };

        public void Start()
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            for (int i = 0; i < array.Length; i++)
            {
                CalculateFactorial(i);
            }

            time.Stop();

            Console.WriteLine();
            Console.WriteLine("Время выполнения: " + time.ElapsedMilliseconds + " мс");
        }

        public void CalculateFactorial(int i)
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