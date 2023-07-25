using System.Threading;

namespace TransportPayment
{
    public partial class TransportCard
    {
        private PaymentHistory _paymentHistory = new PaymentHistory();

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
                Thread threadPay = new Thread(() => _paymentHistory.AddPayInHistory(fare, transport));
                threadPay.Start();
                Thread threadPay2 = new Thread(() => _paymentHistory.AddPayInHistory(fare, transport));
                threadPay2.Start();
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