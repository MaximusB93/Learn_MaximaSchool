using System;

namespace TransportPayment
{
    public class NavigationMenu
    {
        private TransportCard _transportCard = new TransportCard();
        private Notifications _notifications = new Notifications();

        readonly string[] _menu = new[]
        {
            "Пополнить карту",
            "Оплатить проезд",
            "Просмотр истории платежей"
        };

        public void Navigation()
        {
            Console.WriteLine("Выберите пункт меню:");

            for (int i = 0; i < _menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_menu[i]}");
            }

            int selectingItem = int.Parse(Console.ReadLine()); //Выбор пункта меню

            /*switch (selectingItem)
            {
                case 1:
                    _transportCard.notifyOperation += _notifications.NotifyAdd;
                    _transportCard.Add(50);
                    _transportCard.notifyOperation -= _notifications.NotifyAdd;
                    break;
                case 2:
                    _transportCard.notifyOperation += _notifications.NotifyPayment;
                    _transportCard.notifyCashback += _notifications.NotifyCashback;
                    _transportCard.Payment(30);
                    _transportCard.notifyOperation -= _notifications.NotifyPayment;
                    _transportCard.notifyCashback -= _notifications.NotifyCashback;
                    break;
                case 3:
                    PaymentHistory.ViewHistory();
                    break;
     
            }*/
            switch (selectingItem)
            {
                case 1:
                    _transportCard.Add(50);
                    break;
                case 2:

                    _transportCard.Payment(30);
                    break;
                case 3:
                    PaymentHistory.ViewHistory();
                    break;
            }

            ReturnToMenu();
        }

        public void ReturnToMenu()
        {
            Console.WriteLine("Вернуться в меню - 1");
            int a = int.Parse(Console.ReadLine());
            Console.Clear();
            Navigation();
        }
    }
}