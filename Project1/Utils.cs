using System;

namespace Project1
{
    public class Utils
    {
        public static int[] InputElementArray(string inputElement = "")
        {
            Console.WriteLine("Введите элементы массива через запятую");
            string[] strArray = Console.ReadLine().Split(',');
            int[] intArray = Array.ConvertAll(strArray, s => int.Parse(s));
            return intArray;
        }

        public static int InputElement(string inputElement = "")
        {
            Console.WriteLine(inputElement);
            int element = Int32.Parse(Console.ReadLine());
            return element;
        }

        public static void OutputConsoleElement(double element = 0, string comment = "", string separator = "")
        {
            Console.Write($"{comment}{element}{separator}");
        }
    }
}