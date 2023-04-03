using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SquaresNaturalNumbers();
        }

        /// <summary>
        /// Вывод квадратов натуральных чисел
        /// </summary>
        static void SquaresNaturalNumbers()
        {
            Console.WriteLine("Введите предел квадрата чисел");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i * i < N; i++)
                Utils.OutputConsoleElement(i * i);
        }

        /// <summary>
        /// Кубы чисел от A до B
        /// </summary>
        static void СubesNumbers()
        {
            Console.WriteLine("Введите число А");
            int numberA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Int32.Parse(Console.ReadLine());
            for (; numberA <= numberB; numberA++)
                Utils.OutputConsoleElement(numberA * numberA * numberA);
        }

        /// <summary>
        /// Возведение числа в степень
        /// </summary>
        static void ExponentiationNumber()
        {
            Console.WriteLine("Введите число");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int degreeNumber = Int32.Parse(Console.ReadLine());
            int result = number;
            for (int i = 1; i < degreeNumber; i++)
                result *= number;
            Utils.OutputConsoleElement(result, $"Степень числа {number}");
        }

        /*/// <summary>
        /// Вывод таблицы значений функции
        /// </summary>
        static void TableFunctionValues()
        {
            for (double x = -5; x < 6; x += 0.5)
            {
                double y = 5 - x * x / 2;
                Utils.OutputConsoleElement(y, "x = ");
            }
        }*/
    }
}