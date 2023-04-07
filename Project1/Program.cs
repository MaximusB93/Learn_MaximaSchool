using System;

namespace Project1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Операции с массивами");
            Console.WriteLine();
            Console.WriteLine("1) Сумма элементов массива");
            Console.WriteLine("2) Среднее арифметическое элементов массива");
            Console.WriteLine("3) Поиск наименьшего элемента массива");
            Console.WriteLine("4) Подсчет четных элементов массива");
            Console.WriteLine("5) Вывод положительных элементов в новый массив");
            Console.WriteLine("6) Вывод квадратов натуральных чисел");
            Console.WriteLine("7) Кубы чисел от A до B");
            Console.WriteLine("8) Возведение числа в степень");
            Console.WriteLine("9) Вывод таблицы значений функций");
            Console.WriteLine("10) Калькулятор");
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
                        SummElementArray();
                        break;
                    case "2":
                        AverageArithmeticElementArray();
                        break;
                    case "3":
                        SearchMinElementArray();
                        break;
                    case "4":
                        QuantityEvenElementArray();
                        break;
                    case "5":
                        PositiveElementArray();
                        break;
                    case "6":
                        SquaresNaturalNumbers();
                        break;
                    case "7":
                        СubesNumbers();
                        break;
                    case "8":
                        ExponentiationNumber();
                        break;
                    case "9":
                        TableFunctionValues();
                        break;
                    case "10":
                        Calculator();
                        break;
                    default:
                        invalidOperator = true;
                        Console.WriteLine("Введена неверная операция, попробуйте еще раз");
                        break;
                }
            } while (invalidOperator);
        }
        
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
            int QuantityPositivElement = 0;
            for (int i = 0; i < intArray.Length; i++)
                if (intArray[i] > 0)
                    QuantityPositivElement++;
            int[] PositiveArray = new int[QuantityPositivElement];
            for (int i = 0, a = 0; i < intArray.Length; i++)
                if (intArray[i] > 0 && QuantityPositivElement != a + 1)
                {
                    Utils.OutputConsoleElement(PositiveArray[a] = intArray[i], "", ",");
                    a++;
                }
                else if (intArray[i] > 0)
                    Utils.OutputConsoleElement(PositiveArray[a] = intArray[i]);
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