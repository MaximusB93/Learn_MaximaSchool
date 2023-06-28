using System;

namespace TransportPayment
{
    public partial class TransportCard
    {
        public decimal Payment(decimal fare)
        {
            if (Balance < 30)
            {
                Console.WriteLine($"Недостаточно средств для оплаты проезда.\r\nТекущий баланс - {Balance} руб.");
                return Balance;
            }

            Balance -= fare;
            Console.WriteLine(notifyOperation(fare, Balance));
            PaymentHistory.AddPayInHistory(fare);
            GetCashback();
            return Balance;
        }

        public void GetCashback()
        {
            decimal cashback = 30M * 0.1M;
            Balance += cashback;
            Console.WriteLine(notifyCashback(cashback, Balance));
        }
    }
}