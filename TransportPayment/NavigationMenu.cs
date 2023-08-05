using System;

namespace TransportPayment
{
    public class NavigationMenu
    {
        private TransportCard _transportCard;

        public NavigationMenu(TransportCard card)
        {
            _transportCard = card;
        }

        readonly string[] _arrayMenu = new[]
        {
            "Пополнить карту",
            "Оплатить проезд",
            "Просмотр истории платежей"
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
                    _transportCard.Add(_transportCard.DepositАmount());
                    break;
                case 2:
                    _transportCard.Payment(30);
                    break;
                case 3:
                    PaymentHistory.ViewHistory();
                    break;
                default:
                    Console.Clear();
                    Notifications.OnReturnToMenu?.Invoke();
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
                    Notifications.OnReturnToMenu?.Invoke();
                    Navigation();
                    break;
            }
        }
    }
}