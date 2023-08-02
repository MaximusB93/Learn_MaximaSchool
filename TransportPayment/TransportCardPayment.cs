using System.Threading;

namespace TransportPayment
{
    public partial class TransportCard
    {
        private PaymentHistory _paymentHistory = new PaymentHistory();
        private static CreateThread _createThread = new CreateThread();

        public void Payment(decimal fare, string transport)
        {
            if (Balance < fare)
            {
                NotifyError?.Invoke(Balance);
            }
            else
            {
                Balance -= fare;
                NotifyOperation?.Invoke(fare, Balance);
                _createThread.StartingThreads(() => _paymentHistory.AddPayInHistory(fare, transport));
                GetCashback(fare);
            }
        }

        public void GetCashback(decimal fare)
        {
            decimal percentСashback = 0.1M;
            decimal cashback = fare * percentСashback;
            Balance += cashback;
            NotifyCashback(cashback, Balance);
        }
    }
}