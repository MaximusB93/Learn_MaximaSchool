using System;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recurs(5);
        }

        static int Recurs(int n)
        {

            /*if (n >= 5)
            {
                return;
            }
            
            Console.WriteLine(n);
            n++;
            Recurs(n);*/
            
            
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Recurs(n - 1) * n;
            }
        }


        /*static (string, int, int[]) Print()
        {
            string a = "Привет";
            int b = 0;
            int[] c = new int[10];

            return (a, b, c);
        }*/
    }
}