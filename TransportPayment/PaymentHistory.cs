using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TransportPayment;

namespace TransportPayment
{
    public class PaymentHistory
    {
        private static Notifications _notifications = new Notifications();
        private static TransportCard _transportCard = new TransportCard();
        private static NavigationMenu _navigationMenu = new NavigationMenu();

        /*static List<decimal> ListPaymentHistory = new List<decimal>();*/
        static List<Transport> ListPaymentHistory = new List<Transport>();
        static Stack<decimal> StackPaymentHistory = new Stack<decimal>();

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
                    Thread threadView = new Thread(ViewHistory);
                    threadView.Start();
                    Thread threadView2 = new Thread(ViewHistory);
                    threadView2.Start();
                    break;
                case 2:
                    ClearHistory();
                    break;
                case 3:
                    CancelLastPayment();
                    break;
                default:
                    Console.Clear();
                    _notifications.NotifyReturnToMenu();
                    _navigationMenu.Navigation();
                    break;
            }
        }


        public void AddPayInHistory(decimal fare, string transport)
        {
            lock (ListPaymentHistory)
            {
                ListPaymentHistory.Add(new Transport()
                    { Fare = fare, TypeTransport = transport }); //Сохраняем платеж в лист
                StackPaymentHistory.Push(fare); //Сохраняем платеж в стэк
            }
        }

        public void ViewHistory()
        {
            lock (ListPaymentHistory)
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
                _notifications.NotifyCancelLastPayment(lastPayment);
                /*_transportCard.NotifyError?.Invoke(lastPayment);*/
            }
        }

        public void ClearHistory()
        {
            ListPaymentHistory.Clear();
            StackPaymentHistory.Clear();
            _notifications.NotifyClearHistoryPayment();
        }
    }
}