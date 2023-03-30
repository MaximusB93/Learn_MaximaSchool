using System;

namespace Project2
{
    class Program
    {
        //Работа со строками
        static void Main(string[] args)
        {
            string read = Console.ReadLine();

            read = read.Replace(read,"Новая строка");
            Console.WriteLine(read);
            Console.WriteLine(read.ToUpper());
            Console.WriteLine(read.Remove(6));
            Console.WriteLine(read.Substring(6));

        }
    }
}