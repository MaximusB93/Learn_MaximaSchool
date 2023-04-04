using System;

namespace Project1
{
    public class LogicWorkingArrays
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
            Utils.OutputConsoleElement(summ, "Сумма элементов массива");
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

            Utils.OutputConsoleElement(summ / intArray.Length, "Среднее арифметическое элементов массива");
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

            Utils.OutputConsoleElement(minElement,"Наименьший элемент массива");
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

            Utils.OutputConsoleElement(quantityEven,"Количество четных чисел");
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
                {
                    QuantityPositivElement++;
                }

            int a = 0;
            int[] PositiveArray = new int[QuantityPositivElement];
            for (int i = 0; i < intArray.Length; i++)
                if (intArray[i] > 0)
                {
                    PositiveArray[a] = intArray[i];
                    Utils.OutputConsoleElement(PositiveArray[a],",");
                    a++;
                }
        }
    }
}