using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SquaresNaturalNumbers();
            СubesNumbers();
            ExponentiationNumber();
            TableFunctionValues();*/
            Calculator();
        }

        /// <summary>
        /// Вывод квадратов натуральных чисел
        /// </summary>
        public static void SquaresNaturalNumbers()
        {
            int numberN = Utils.InputElement("Введите предел квадрата чисел");
            for (int i = 1; i * i < numberN; i++)
            {
                if (i > numberN / (i + 2))
                    Utils.OutputConsoleElement(i * i);
                else
                    Utils.OutputConsoleElement(i * i, "", ",");
            }


            Console.WriteLine();
        }

        /// <summary>
        /// Кубы чисел от A до B
        /// </summary>
        public static void СubesNumbers()
        {
            int numberA = Utils.InputElement("Введите число А");
            int numberB = Utils.InputElement("Введите число B");
            for (; numberA <= numberB; numberA++)
            {
                if (numberA == numberB)
                    Utils.OutputConsoleElement(numberA * numberA * numberA);
                else
                    Utils.OutputConsoleElement(numberA * numberA * numberA, "", ",");
            }

            Console.WriteLine();
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
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод таблицы значений функций
        /// </summary>
        static void TableFunctionValues()
        {
            for (double x = -5; x <= 5; x += 0.5)
            {
                double y = 5 - x * x / 2;
                Utils.OutputConsoleElement(x, "x = ", " | ");
                Utils.OutputConsoleElement(y, "y = ");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Калькулятор
        /// </summary>
        static void Calculator()
        {
            int x = Utils.InputElement("Введите первое число");
            int y = Utils.InputElement("Введите второе число");
            do
                {
                    Console.WriteLine("Введите операцию + - * / %");
                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "+":
                            Utils.OutputConsoleElement(x + y,"Сложение чисел = ");
                            break;
                        case "-":
                            Utils.OutputConsoleElement(x - y,"Вычитание числа = ");
                            break;
                        case "*":
                            Utils.OutputConsoleElement(x * y,"Умножение чисел = ");
                            break;
                        case "/":
                            Utils.OutputConsoleElement(x / y,"Деление числа = ");
                            break;
                        case "%":
                            Utils.OutputConsoleElement(x % y,"Остаток от деления = ");
                            break;
                        default:
                            Console.WriteLine("Введена неверная операция, попробуйте еще раз");
                            break;
                    }
                } while (default);
        }
    }
}