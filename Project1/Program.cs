using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Вывод квадратов натуральных чисел
            Console.WriteLine("Введите предел квадрата чисел");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i * i < N; i++)
                Console.Write($"{i * i} ");*/


            /*//Кубы чисел от A до B
            Console.WriteLine("Введите число А");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Int32.Parse(Console.ReadLine());
            for (; A <= B; A++)
                Console.Write($"{A * A * A} ");*/

            //Кубы чисел от A до B
            Console.WriteLine("Введите число");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень числа");
            int B = Int32.Parse(Console.ReadLine());
            int V = A;
            for (int i = 1; i < B; i++)
                V = A * V;
            Console.WriteLine(V);
            Console.ReadLine();
        }
    }
}