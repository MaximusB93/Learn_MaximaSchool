using System;

namespace TransportPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportCard transportCard = new TransportCard();
            transportCard.notifyOperation += NotifyReplenishment;
            transportCard.Replenishment(50);
            transportCard.notifyOperation -= NotifyReplenishment;
            transportCard.notifyOperation += NotifyPayment;
            transportCard.Payment();
            transportCard.notifyOperation -= NotifyPayment;
            transportCard.notifyOperation += NotifyCashback;
            transportCard.GetCashback();
            transportCard.notifyOperation -= NotifyCashback;
        }

        public static string NotifyReplenishment(decimal amount, decimal balance)
        {
            return $"Пополнение на {amount} руб.\r\nТекущий баланс - {balance} руб.";
        }

        public static string NotifyPayment(decimal fare, decimal balance)
        {
            return $"Оплата проезда - {fare} руб. прошла успешно.\r\nТекущий баланс - {balance} руб.";
        }
        public static string NotifyCashback(decimal cashback, decimal balance)
        {
            return $"Вы получили {cashback} руб. кэшбека.\r\nТекущий баланс - {balance} руб.";
        }
    }
}