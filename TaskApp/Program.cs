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
        private static int[] array = new[] { 11, 7, 8, 10 };

        static void Main(string[] args)
        {
            MultiThread multiThread = new MultiThread(array);
            multiThread.Start();
            SingleThread singleThread = new SingleThread(array);
            singleThread.Start();
        }
    }
}