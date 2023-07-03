using System;

namespace TransportPayment
{
    public partial class TransportCard
    {
        public delegate void NotifyOperationDelegate(decimal amount, decimal balance);

        public NotifyOperationDelegate NotifyOperation;

        public Action<decimal> NotifyError;

        public Action<decimal, decimal> NotifyCashback;
        public decimal Balance { get; set; }

        public decimal DepositАmount()
        {
            Console.WriteLine("Введите сумму");
            decimal amount = decimal.Parse(Console.ReadLine() ?? string.Empty);
            return amount;
        }

        public void Add(decimal amount)
        {
            Balance += amount;
            NotifyOperation?.Invoke(amount, Balance);
        }
    }
}