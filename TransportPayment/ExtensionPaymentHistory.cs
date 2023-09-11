using System;
using System.Linq;

namespace TransportPayment
{
    public static class ExtensionPaymentHistory
    {
        private static TransportCard _transportCard = new TransportCard();

        public static void CancelHistory(this PaymentHistory PaymentHistory)
        {
            if (PaymentHistory.ListPaymentHistory.Count == 0)
            {
                Console.WriteLine("Нет операций для отмены");
            }
            else
            {
                var lastPayment = PaymentHistory.ListPaymentHistory.Last();
                PaymentHistory.ListPaymentHistory.Remove(lastPayment);
            }
        }
    }
}