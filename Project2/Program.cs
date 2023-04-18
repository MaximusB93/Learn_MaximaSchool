using System;

namespace Project2
{
    /// <summary>
    /// Числа Фибоначчи(https://pas1.ru/fibonacci)
    /// </summary>
    class  Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество чисел Фибоначчи");
            int a = 0;
            int b = 1;
            int count = 0;
            Console.Write($"{a}, {b}, ");
            RecursSequenceFibonacci(Int32.Parse(Console.ReadLine() ?? string.Empty), a, b, count);
        }

        static void RecursSequenceFibonacci(int n, int a, int b, int count)
        {
            if (count == n - 2)
                return;
            if (count < n - 3)
            {
                b = a + b;
                a = b - a;
                count++;
                Console.Write(count < n - 3 ? $"{b}, " : $"{b}");
                RecursSequenceFibonacci(n, a, b, count);
            }
        }
    }
}