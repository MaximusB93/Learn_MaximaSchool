using System;
using System.Linq;

namespace Project1
{
    internal class Program
    {
        //Сумма элементов одномерного массива
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через запятую");
            string[] strArray = Console.ReadLine().Split(',');
            int[] intArray = new int[strArray.Length];
            int summ = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = Int32.Parse(strArray[i]);
                summ += intArray[i];
            }
            Console.WriteLine($"Сумма элементов массива - {summ}");
            Console.ReadLine();
        }
    }
}