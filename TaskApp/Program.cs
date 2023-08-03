using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу.Дан список чисел(одномерный массив).Нужно в количестве равном N создать
            //     таски, внутри которых будет расчет факториалов для каждого числа из заданного списка.То есть параллельно
            //     пробежаться по списку чисел и распораллелить вычисление факториалов.
            //
            // Измерить время выполнения
            //     для однопоточной обработки списка(N = 1) и для N = 4(степень параллелизма)


            int[] array = new[] { 5, 6, 7, 8 };
            List<Task<int>> tasksList = new List<Task<int>>();
            int result = 1;
            for (int i = 0; i < array.Length; i++)
            {
               
                tasksList.Add(CalculateFactorial);


                for (int y = 2; y < array[i] + 1; y++)
                {
                    result *= y;
                }

                Console.WriteLine(result);
                result = 1;
            }
        }

        public async Task MyTaskFunction(int id)
        {
            // Ваш код для выполнения в задаче
            await Task.Delay(1000);
            Console.WriteLine($"Задача {id} завершена.");
        }

        public static async Task<int> CalculateFactorial()
        {
            return 5;
        }
    }
}