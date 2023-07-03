using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public class PaymentHistory
    {
        private static Notifications _notifications = new Notifications();
        private static TransportCard _transportCard = new TransportCard();

        static readonly List<decimal> ListPaymentHistory = new List<decimal>();
        static Stack<decimal> stack = new Stack<decimal>();

        public static void AddPayInHistory(decimal fare)
        {
            ListPaymentHistory.Add(fare);
            stack.Push(fare);
        }

        public static void ViewHistory()
        {
            if (ListPaymentHistory.Count == 0)
            {
                Console.WriteLine("Список оплат пуст");
            }
            else
            {
                for (int i = 0; i < ListPaymentHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Оплачено - {ListPaymentHistory[i]} руб.");
                }
            }
        }

        public static void CancelLastPayment()
        {
           var lastPayment = stack.Pop();
            _transportCard.NotifyError?.Invoke(lastPayment);
        }
    }
}