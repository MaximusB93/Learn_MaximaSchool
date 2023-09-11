using System;

namespace TransportPayment
{
    public partial class TransportCard
    {
        public delegate void NotifyOperationDelegate(decimal amount, decimal balance);

        public event NotifyOperationDelegate NotifyAdd;
        public event NotifyOperationDelegate NotifyPayment;
        public event Action<decimal> NotifyError;
        public event Action<decimal, decimal> NotifyCashback;
        public Action OnReturnToMenu;
        public Action CancelLastPayment;

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
            NotifyAdd?.Invoke(amount, Balance);
        }
    }
}