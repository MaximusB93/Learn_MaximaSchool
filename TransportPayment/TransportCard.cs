using System;
using System.Collections.Generic;

namespace TransportPayment
{
    public partial class TransportCard
    {
        public delegate void OnAddMoney(decimal count, decimal balance);
        public static OnAddMoney onAddMoney;
        public delegate string NotifyOperation(decimal amount, decimal balance);

        public NotifyOperation notifyOperation;
        public event NotifyOperation notifyOperationEvent; //разобраться

        public Func<decimal, decimal, string> notifyCashback;
        public Predicate<decimal> predicate; //разобраться
        
        public decimal Balance { get; set; }

        public decimal Add(decimal amount)
        {
            Balance += amount;
            onAddMoney?.Invoke(amount, Balance);
            return Balance;
        }
    }
}