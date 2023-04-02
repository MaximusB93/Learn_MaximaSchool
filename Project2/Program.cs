using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Project2
{
    class Program
    {
        //Работа со строками
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название фруктов через запятую");
            string read = Console.ReadLine();

            //Разбивка строки по элементам массива
            string[] fruits = read.Split(',');
            for (int i = 0; i < fruits.Length; i++)
                Console.WriteLine(fruits[i]);

            //Перевод в верхний регистр
            Console.WriteLine(read.ToUpper());

            //Перезапись строки
            read = read.Replace(read, "Перезаписали строку");
            Console.WriteLine(read);

            //Добавили доп слово
            Console.WriteLine(read.Insert(13, "нашу "));
            
            //Удаление части строки
            Console.WriteLine(read.Remove(12));
            Console.WriteLine(read.Substring(13));
        }
    }
}