using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TaskApp
{
    public class SingleThread
    {
        private int[] _array;

        public SingleThread(int[] array)
        {
            this._array = array;
        }

        public void Start()
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            for (int i = 0; i < _array.Length; i++)
            {
                CalculateFactorial(i);
            }

            time.Stop();

            Console.WriteLine();
            Console.WriteLine("Время выполнения однопоточки: " + time.ElapsedMilliseconds + " мс");
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