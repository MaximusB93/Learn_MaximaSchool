using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogicWorkingArrays.PositiveElementArray();
        }

        /// <summary>
        /// Вывод квадратов натуральных чисел
        /// </summary>
        public static void SquaresNaturalNumbers()
        {
            int numberN = Utils.InputElement("Введите предел квадрата чисел");
            for (int i = 1; i * i < numberN; i++)
                Utils.OutputConsoleElement(i * i);
        }

        /// <summary>
        /// Кубы чисел от A до B
        /// </summary>
        public static void СubesNumbers()
        {
            int numberA = Utils.InputElement("Введите число А");
            int numberB = Utils.InputElement("Введите число B");
            for (; numberA <= numberB; numberA++)
                Utils.OutputConsoleElement(numberA * numberA * numberA);
        }

        /// <summary>
        /// Возведение числа в степень
        /// </summary>
        public static void ExponentiationNumber()
        {
            int number = Utils.InputElement("Введите число");
            int degreeNumber = Utils.InputElement("Введите степень числа");
            int result = number;
            for (int i = 1; i < degreeNumber; i++)
                result *= number;
            Utils.OutputConsoleElement(result, $"Степень числа {number} = ");
        }

        /// <summary>
        /// Вывод таблицы значений функции
        /// </summary>
        static void TableFunctionValues()
        {
            for (double x = -5; x < 6; x += 0.5)
            {
                double y = 5 - x * x / 2;
                Utils.OutputConsoleElement(y, "x = ");
            }
        }
    }
}