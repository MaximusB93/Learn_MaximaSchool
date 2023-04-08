using System;

namespace Project1
{
    internal class Program
    {
        enum MyEnum
        {
            Red = 1,
            Yellow = 2,
            Gren = 3
        }

        static void Main(string[] args)
        {

            bool a = Enum.IsDefined(typeof(MyEnum),5);
                Console.WriteLine(a);
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