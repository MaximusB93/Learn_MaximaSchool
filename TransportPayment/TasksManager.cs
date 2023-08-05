using System;
using System.Threading.Tasks;

namespace TransportPayment
{
    public class TasksManager
    {
        private static int _numberThreads = 2;
        private Task[] _tasks = new Task[_numberThreads];

        public void StartTasks(Action method)
        {
            for (int i = 0; i < _tasks.Length; i++)
                _tasks[i] = Task.Run(() => method.Invoke());
        }
    }
}