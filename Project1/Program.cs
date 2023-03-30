using System;
using System.Net.Http.Json;

namespace Project1
{
    internal class Program
    {
        //Работа с числами
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = Int32.Parse(Console.ReadLine());


            Console.WriteLine($"Сложение чисел - {firstNumber + secondNumber}");

            Console.WriteLine($"Вычитание второго числа от первого - {firstNumber - secondNumber}");

            Console.WriteLine($"Умножение чисел - {firstNumber * secondNumber}");

            Console.WriteLine($"Деление первого числа на второе - {firstNumber / secondNumber}");
        }
    }
}