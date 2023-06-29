using System;

namespace TransportPayment
{
    public class Notifications
    {
        public void Active()
        {
            TransportCard.onAddMoney += NotifyAdd;
        }

        public void NotifyAdd(decimal amount, decimal balance)
        {
            Console.WriteLine($"Пополнение на {amount} руб.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyPayment(decimal fare, decimal balance)
        {
            Console.WriteLine($"Оплата проезда - {fare} руб. прошла успешно.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyCashback(decimal cashback, decimal balance)
        {
            Console.WriteLine($"Вы получили {cashback} руб. кэшбека.\r\nТекущий баланс - {balance} руб.");
        }
    }
}