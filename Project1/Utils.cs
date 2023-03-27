using System;

namespace Project1
{
    public class Utils
    {
        public static int[] InputElementArray()
        {
            Console.WriteLine("Введите элементы массива через запятую");
            string[] strArray = Console.ReadLine().Split(',');
            int[] intArray = Array.ConvertAll(strArray, s => int.Parse(s));
            return intArray;
        }

        public static void OutputConsoleElement(double element)
        {
            Console.WriteLine(element);
            Console.ReadLine();
        }
    }
}