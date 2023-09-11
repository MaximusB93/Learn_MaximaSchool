namespace TransportPayment
{
    public partial class TransportCard
    {
        private Transport _transport = new Transport();
        private PaymentHistory _paymentHistory = new PaymentHistory();

        public void Payment()
        {
            var (fare, typeTransport) = _transport.GetTransport();

            if (Balance < fare)
            {
                NotifyError?.Invoke(Balance);
            }
            else
            {
                Balance -= fare;
                NotifyPayment?.Invoke(fare, Balance);
                _paymentHistory.AddPayInHistory(fare, typeTransport);
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