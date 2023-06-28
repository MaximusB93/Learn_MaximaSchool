using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public partial class TransportCard
    {
        public delegate string NotifyOperation(decimal amount, decimal balance);

        public NotifyOperation notifyOperation;
        public event NotifyOperation notifyOperationEvent; //разобраться

        public Func<decimal, decimal, string> notifyCashback;
        public Predicate<decimal> predicate; //разобраться


        public decimal Balance { get; set; }

        public decimal Replenishment(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(notifyOperation(amount, Balance));
            return Balance;
        }
    }
}