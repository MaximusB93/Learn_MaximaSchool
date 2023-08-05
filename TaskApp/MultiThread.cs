using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TaskApp
{
    public class MultiThread
    {
        private int[] _array;

        public MultiThread(int[] array)
        {
            this._array = array;
        }

        public void Start()
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            Task[] tasksList = new Task [_array.Length];

            for (int i = 0; i < _array.Length; i++)
            {
                int index = i;
                tasksList[i] = Task.Run(() => CalculateFactorial(index));
            }

            Task.WaitAll(tasksList);
            time.Stop();

            Console.WriteLine();
            Console.WriteLine("Время выполнения многопоточки: " + time.ElapsedMilliseconds + " мс");
        }

        public void CalculateFactorial(int i)
        {
            int result = 1;
            for (int y = 2; y < _array[i] + 1; y++)
            {
                result *= y;
            }

            Console.WriteLine($"Факториал числа {_array[i]} равен: {result}");
        }
    }
}