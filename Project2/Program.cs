using System;
using System.Data;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int N = Int32.Parse(Console.ReadLine());
            int count = 0;
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            Recurs(N, a, b, count);*/
            int a = 1;
            int N = Int32.Parse(Console.ReadLine());
            Recurs2(N, a);
        }

        static void Recurs2(int N, int a)
        {
            if (a > N)
            {
                return;
            }

            Console.Write(a);
            Recurs2(N, ++a);
        }


        /*static void Recurs(int N, int a, int b, int count)
        {
            if (count == N - 2)
            {
                return;
            }
            Console.WriteLine(b = a + b);
            a = b - a;
            count++;
            Recurs(N, a, b, count);
        }*/
    }
}