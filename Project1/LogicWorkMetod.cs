using System;

namespace Project1
{
    public class LogicWorkMetod
    {
        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        public static void SummElementArray()
        {
            int[] intArray = Utils.InputElementArray();
            int summ = 0;

            for (int i = 0; i < intArray.Length; i++)
                summ += intArray[i];
            Utils.OutputConsoleElement(summ, "Сумма элементов массива = ");
        }

        /// <summary>
        /// Среднее арифметическое элементов массива
        /// </summary>
        public static void AverageArithmeticElementArray()
        {
            int[] intArray = Utils.InputElementArray();
            int summ = 0;
            for (int i = 0; i < intArray.Length; i++)
                summ += intArray[i];
            Utils.OutputConsoleElement(summ / intArray.Length, "Среднее арифметическое элементов массива = ");
        }

        /// <summary>
        /// Поиск наименьшего элемента массива
        /// </summary>
        public static void SearchMinElementArray()
        {
            int[] intArray = Utils.InputElementArray();
            int minElement = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < minElement)
                    minElement = intArray[i];
            }

            Utils.OutputConsoleElement(minElement, "Наименьший элемент массива = ");
        }

        /// <summary>
        /// Подсчет четных элементов массива
        /// </summary>
        public static void QuantityEvenElementArray()
        {
            int[] intArray = Utils.InputElementArray();
            int quantityEven = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                    quantityEven++;
            }

            Utils.OutputConsoleElement(quantityEven, "Количество четных чисел = ");
        }

        /// <summary>
        /// Вывод положительных элементов в новый массив
        /// </summary>
        public static void PositiveElementArray()
        {
            int[] intArray = Utils.InputElementArray();
            int quantityPositivElement = 0;
            for (int i = 0; i < intArray.Length; i++)
                if (intArray[i] > 0)
                    quantityPositivElement++;
            int[] positiveArray = new int[quantityPositivElement];
            Console.WriteLine("Положительные элементы массива");
            for (int i = 0, a = 0; i < intArray.Length; i++)
                if (intArray[i] > 0 && quantityPositivElement != a + 1)
                    Utils.OutputConsoleElement(positiveArray[a++] = intArray[i], "", ",");
                else if (intArray[i] > 0)
                    Utils.OutputConsoleElement(positiveArray[a] = intArray[i]);
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
        public static void TableFunctionValues()
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
        public static void Calculator()
        {
            int x = Utils.InputElement("Введите первое число");
            int y = Utils.InputElement("Введите второе число");
            bool invalidOperator;
            do
            {
                invalidOperator = false;
                Console.WriteLine("Введите операцию + - * / %");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Utils.OutputConsoleElement(x + y, "Сложение чисел = ");
                        break;
                    case "-":
                        Utils.OutputConsoleElement(x - y, "Вычитание числа = ");
                        break;
                    case "*":
                        Utils.OutputConsoleElement(x * y, "Умножение чисел = ");
                        break;
                    case "/":
                        Utils.OutputConsoleElement(x / y, "Деление числа = ");
                        break;
                    case "%":
                        Utils.OutputConsoleElement(x % y, "Остаток от деления = ");
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