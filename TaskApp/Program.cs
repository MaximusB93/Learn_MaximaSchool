using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskApp
{
    // Написать программу.Дан список чисел(одномерный массив).Нужно в количестве равном N создать
    //     таски, внутри которых будет расчет факториалов для каждого числа из заданного списка.То есть параллельно
    //     пробежаться по списку чисел и распораллелить вычисление факториалов.
    //
    // Измерить время выполнения
    //     для однопоточной обработки списка(N = 1) и для N = 4(степень параллелизма)

    class Program
    {
        private static int[] array = new[] { 5, 6, 7, 8 };
        private static object _sync = new object();

        //static List<Task<int>> tasksList = new List<Task<int>>();
        static public Task[] tasksList = new Task [array.Length];
        static int result;

        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            for (int i = 0; i < array.Length; i++)
            {
                lock (_sync)
                {
                    result = 1;
                    Task<int> task = new Task<int>(() => CalculateFactorial(i));
                    tasksList[i] = task;
                    //tasksList.Add(task);
                    tasksList[i].Start();
                }
            }

            Task.WaitAll(tasksList);
            time.Stop();
            Console.WriteLine();
            Console.WriteLine(time.ElapsedMilliseconds);
        }

        public static int CalculateFactorial(int i)
        {
            lock (_sync)
            {
                for (int y = 2; y < array[i] + 1; y++)
                {
                    result *= y;
                }
            }

            Console.WriteLine(result);
            return result;
        }
    }
}