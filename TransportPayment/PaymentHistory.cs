using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public class PaymentHistory
    {
        private static readonly List<decimal> _listPaymentHistory = new List<decimal>();

        public static void AddPayInHistory(decimal fare)
        {
            _listPaymentHistory.Add(fare);
            _listPaymentHistory.Clear();
        }

        public static void ViewHistory()
        {
            if (_listPaymentHistory.Count == 0)
            {
                Console.WriteLine("Список оплат пуст");
            }
            else
            {
                for (int i = 0; i < _listPaymentHistory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) Оплачено - {_listPaymentHistory[i]} руб.");
                }
            }
        }
        public static void RemoveHistory()
        {
            _listPaymentHistory.RemoveAll(null);
        }
        
    }
}