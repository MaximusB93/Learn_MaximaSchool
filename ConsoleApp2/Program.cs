using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            
            return;
                
                
            /*Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(9);
            queue.Enqueue(8);

            var array = queue.ToArray();

            while (queue.TryDequeue(out var a))
            {
                Console.WriteLine(a);
            }
           
            var array2 = queue.ToArray();*/


            /*List<int> list = new List<int>();
            
            list.Add(10);
            list.Add(8);
            list.Add(6);
            list.Add(7);

           var a =  list.Contains(5);
            Console.WriteLine(a);
            Console.WriteLine(String.Join(",", list));*/
        }
    }
}