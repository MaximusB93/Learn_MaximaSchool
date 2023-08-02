using System;

namespace TransportPayment
{
    public class NavigationMenu
    {
        private TransportCard _transportCard = new TransportCard();
        private Notifications _notifications = new Notifications();
        private PaymentHistory _paymentHistory = new PaymentHistory();
        private Transport _transport = new Transport();

        readonly string[] _arrayMenu = new[]
        {
            "Пополнить карту",
            "Оплатить проезд",
            "История платежей",
        };

        public void Navigation()
        {
            Console.WriteLine("Выберите пункт меню:");

            for (int i = 0; i < _arrayMenu.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_arrayMenu[i]}");
            }

            int selectingItem = int.Parse(Console.ReadLine() ?? string.Empty); //Выбор пункта меню

            switch (selectingItem)
            {
                case 1:
                    _transportCard.NotifyOperation += _notifications.NotifyAdd;
                    _transportCard.Add(_transportCard.DepositАmount());
                    _transportCard.NotifyOperation -= _notifications.NotifyAdd;
                    break;
                case 2:
                    _transportCard.NotifyError += _notifications.NotifyЕrror;
                    _transportCard.NotifyOperation += _notifications.NotifyPayment;
                    _transportCard.NotifyCashback += _notifications.NotifyCashback;
                    var transport = _transport.GetTransport();
                    _transportCard.Payment(transport.Item1, transport.Item2);
                    _transportCard.NotifyError -= _notifications.NotifyЕrror;
                    _transportCard.NotifyOperation -= _notifications.NotifyPayment;
                    _transportCard.NotifyCashback -= _notifications.NotifyCashback;
                    break;
                case 3:
                    _paymentHistory.GetHistory();
                    break;
                default:
                    Console.Clear();
                    _notifications.NotifyReturnToMenu();
                    Navigation();
                    break;
            }

            ReturnToMenu();
        }

        public void ReturnToMenu()
        {
            Console.WriteLine("Вернуться в меню - 1");
            int number = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Clear();
            switch (number)
            {
                case 1:
                    Navigation();
                    break;
                default:
                    _notifications.NotifyReturnToMenu();
                    Navigation();
                    break;
            }
        }
    }
}