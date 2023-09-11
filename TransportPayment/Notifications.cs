using System;

namespace TransportPayment
{
    public class Notifications
    {
        //public static Action OnReturnToMenu;
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
            _transportCard.CancelLastPayment += NotifyCancelLastPayment;
            _transportCard.OnReturnToMenu += NotifyReturnToMenu;
            _transportCard.ClearHistoryPayment += NotifyClearHistoryPayment;
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

        public void NotifyCancelLastPayment(decimal lastPayment)
        {
            Console.WriteLine($"Последний платеж {lastPayment} руб. отменен.\r\n");
        }

        public void NotifyClearHistoryPayment()
        {
            Console.WriteLine($"История платежей очищена.\r\n");
        }
    }
}