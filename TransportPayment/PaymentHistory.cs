using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TransportPayment;

namespace TransportPayment
{
    public class PaymentHistory
    {
        private object _lockObj = new object();
        private static Notifications _notifications = new Notifications(_transportCard);
        private static TransportCard _transportCard = new TransportCard();
        private static NavigationMenu _navigationMenu;
        private static TasksManager _tasksManager = new TasksManager();

        public static List<Transport> ListPaymentHistory = new List<Transport>();
        public static Stack<decimal> StackPaymentHistory = new Stack<decimal>();

        private readonly string[] _historyMenu =
        {
            "Просмотр истории",
            "Очистить историю",
            "Отменить последний платеж"
        };


        public void GetHistory()
        {
            Console.WriteLine("Выберите пункт:");

            for (int i = 0; i < _historyMenu.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_historyMenu[i]}");
            }

            int selectingItem = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (selectingItem)
            {
                case 1:
                    _tasksManager.StartTasks(ViewHistory);
                    break;
                case 2:
                    ClearHistory();
                    break;
                case 3:
                    CancelLastPayment();
                    break;
                default:
                    Console.Clear();
                    _transportCard.OnReturnToMenu();
                    _navigationMenu.Navigation();
                    break;
            }
        }


        public void AddPayInHistory(decimal fare, string transport)
        {
            lock (_lockObj)
            {
                ListPaymentHistory.Add(new Transport()
                    { Fare = fare, TypeTransport = transport }); //Сохраняем платеж в лист
                StackPaymentHistory.Push(fare); //Сохраняем платеж в стэк
            }
        }

        public void ViewHistory()
        {
            lock (_lockObj)
            {
                if (ListPaymentHistory.Count == 0)
                {
                    Console.WriteLine("Список оплат пуст");
                }
                else
                {
                    for (int i = 0; i < ListPaymentHistory.Count; i++)
                    {
                        Console.WriteLine(
                            $"{i + 1}) Оплачено {ListPaymentHistory[i].TypeTransport} - {ListPaymentHistory[i].Fare} руб.");
                    }
                }
            }
        }

        public void CancelLastPayment()
        {
            if (StackPaymentHistory.Count == 0)
            {
                Console.WriteLine("Нет операций для отмены");
            }
            else
            {
                var lastPayment = StackPaymentHistory.Pop(); //Извлекаем из стека последний элемент
                ListPaymentHistory.Last();
                ListPaymentHistory.Remove(new Transport()); //Удаляем этот элемент из листа
                _transportCard.NotifyError?.Invoke(lastPayment);
            }
        }

        public void ClearHistory()
        {
            ListPaymentHistory.Clear();
            StackPaymentHistory.Clear();
            _transportCard.ClearHistoryPayment?.Invoke();
        }
    }
}