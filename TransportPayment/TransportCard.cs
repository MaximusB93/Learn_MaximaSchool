using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public class TransportCard
    {
        public delegate string NotifyOperation(decimal amount, decimal balance);

        public Func<string> notifyCashback;

        public NotifyOperation notifyOperation;

        public decimal Balance { get; set; }

        public decimal Replenishment(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(notifyOperation(amount, Balance));
            return Balance;
        }

        public decimal Payment()
        {
            decimal fare = 30M;
            if (Balance < 30)
            {
                Console.WriteLine($"Недостаточно средств для оплаты проезда.\r\nТекущий баланс - {Balance} руб.");
                return Balance;
            }

            Balance -= fare;
            Console.WriteLine(notifyOperation(fare, Balance));
            Console.WriteLine(notifyCashback());
            return Balance;
        }

        public decimal GetCashback()
        {
            decimal cashback = 30M * 0.1M;
            Balance += cashback;
            return cashback;
        }
    }
}