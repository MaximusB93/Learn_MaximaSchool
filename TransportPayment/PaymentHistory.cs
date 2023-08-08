using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public class PaymentHistory
    {
        public static readonly List<decimal> ListPaymentHistory = new List<decimal>();

        public static void AddPayInHistory(decimal fare)
        {
            ListPaymentHistory.Add(fare);
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
    }
}