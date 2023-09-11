namespace TransportPayment
{
    public partial class TransportCard
    {
        public void Payment(decimal fare)
        {
            if (Balance < fare)
            {
                NotifyError?.Invoke(Balance);
            }
            else
            {
                Balance -= fare;
                NotifyPayment?.Invoke(fare, Balance);
                PaymentHistory.AddPayInHistory(fare);
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