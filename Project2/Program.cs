using System;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int count = 0;
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            Recurs(N, a, b, count);
        }

        static void Recurs(int N, int a, int b, int count)
        {
            if (count == N - 2)
            {
                return;
            }
            Console.WriteLine(b = a + b);
            a = b - a;
            count++;
            Recurs(N, a, b, count);
        }
    }
}