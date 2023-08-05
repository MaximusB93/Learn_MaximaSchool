using System;

namespace TransportPayment
{
    public class Notifications
    {
        public static Action OnReturnToMenu;
        private TransportCard _transportCard;

        public Notifications(TransportCard card)
        {
            _transportCard = card;
        }

        public void Subscribe()
        {
            _transportCard.NotifyAdd += NotifyAdd;
            _transportCard.NotifyError += NotifyЕrror;
            _transportCard.NotifyPayment += NotifyPayment;
            _transportCard.NotifyCashback += NotifyCashback;
            OnReturnToMenu += NotifyReturnToMenu;
        }

        public void NotifyAdd(decimal amount, decimal balance)
        {
            Console.WriteLine($"Пополнение на {amount} руб.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyPayment(decimal fare, decimal balance)
        {
            Console.WriteLine($"Оплата проезда - {fare} руб. прошла успешно.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyЕrror(decimal balance)
        {
            Console.WriteLine($"Недостаточно средств для оплаты проезда.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyCashback(decimal cashback, decimal balance)
        {
            Console.WriteLine($"Вы получили {cashback} руб. кэшбека.\r\nТекущий баланс - {balance} руб.");
        }

        public void NotifyReturnToMenu()
        {
            Console.WriteLine($"Команда не распознана, возврат в меню.\r\n");
        }
    }
}