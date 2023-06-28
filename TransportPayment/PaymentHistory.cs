using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public class PaymentHistory
    {
        static List<decimal> listPaymentHistory = new List<decimal>();

        public static void AddPayInHistory(decimal fare)
        {
            listPaymentHistory.Add(fare);
        }

        public static void ViewHistory()
        {
            if (listPaymentHistory.Count == 0)
            {
                Console.WriteLine("У вас не было оплат");
            }

            foreach (var list in listPaymentHistory)
            {
                Console.WriteLine(list);
            }
        }
    }
}