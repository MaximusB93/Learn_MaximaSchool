namespace TransportPayment
{
    public class Notifications
    {
        public string NotifyReplenishment(decimal amount, decimal balance)
        {
            return $"Пополнение на {amount} руб.\r\nТекущий баланс - {balance} руб.";
        }

        public string NotifyPayment(decimal fare, decimal balance)
        {
            return $"Оплата проезда - {fare} руб. прошла успешно.\r\nТекущий баланс - {balance} руб.";
        }

        public string NotifyCashback(decimal cashback, decimal balance)
        {
            return $"Вы получили {cashback} руб. кэшбека.\r\nТекущий баланс - {balance} руб.";
        }
    }
}