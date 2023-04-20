using System;

namespace Project1
{
    public class OutputMetod
    {
        private static string[] nameMetod =
        {
            "Сумма элементов массива",
            "Среднее арифметическое элементов массива",
            "Поиск наименьшего элемента массива",
            "Подсчет четных элементов массива",
            "Вывод положительных элементов в новый массив",
            "Вывод квадратов натуральных чисел",
            "Кубы чисел от A до B",
            "Возведение числа в степень",
            "Вывод таблицы значений функций",
            "Калькулятор"
        };

        public static void OutputMetodConsole()
        {
            Console.WriteLine("Операции с массивами");
            for (int i = 0; i < nameMetod.Length; i++)
                Console.WriteLine($"{i + 1}) {nameMetod[i]}");
            Console.WriteLine();

            bool invalidOperator;
            do
            {
                invalidOperator = false;
                Console.WriteLine("Введите номер операции с массивами");
                string numberOperation = Console.ReadLine();
                switch (numberOperation)
                {
                    case "1":
                        LogicWorkMetod.SummElementArray();
                        break;
                    case "2":
                        LogicWorkMetod.AverageArithmeticElementArray();
                        break;
                    case "3":
                        LogicWorkMetod.SearchMinElementArray();
                        break;
                    case "4":
                        LogicWorkMetod.QuantityEvenElementArray();
                        break;
                    case "5":
                        LogicWorkMetod.PositiveElementArray();
                        break;
                    case "6":
                        LogicWorkMetod.SquaresNaturalNumbers();
                        break;
                    case "7":
                        LogicWorkMetod.СubesNumbers();
                        break;
                    case "8":
                        LogicWorkMetod.ExponentiationNumber();
                        break;
                    case "9":
                        LogicWorkMetod.TableFunctionValues();
                        break;
                    case "10":
                        LogicWorkMetod.Calculator();
                        break;
                    default:
                        invalidOperator = true;
                        Console.WriteLine("Введена неверная операция, попробуйте еще раз");
                        break;
                }
            } while (invalidOperator);
        }
    }
}