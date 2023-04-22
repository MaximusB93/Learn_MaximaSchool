using System;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ivan = new Man("Ваня", 10, 140, 50, Man.Color.Blue);
            var Ivan1 = new Man("Ваня", 10, 140, 50, Man.Color.Blue);
            var Ivan2 = new Man("Ваня", 10, 140, 50, Man.Color.Blue);
            var Ivan3 = new Man("Ваня", 10, 140, 50, Man.Color.Blue);
            
            
            
            Console.WriteLine(Ivan.Age);
            Ivan.Age = 99;
            Console.WriteLine(Ivan.Age);
            Console.WriteLine(Man.GetNumber());
        }
    }
}