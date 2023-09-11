using System;

namespace TransportPayment
{
    public class NavigationMenu
    {
        private TransportCard _transportCard = new TransportCard();
        private PaymentHistory _paymentHistory = new PaymentHistory();

        public NavigationMenu(TransportCard card)
        {
            _transportCard = card;
        }

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

            int selectingItem = int.Parse(Console.ReadLine()); //Выбор пункта меню

            switch (selectingItem)
            {
                case 1:
                    _transportCard.Add(_transportCard.DepositАmount());
                    break;
                case 2:
                    _transportCard.Payment();
                    break;
                case 3:
                    _paymentHistory.GetHistory();
                    break;
                default:
                    Console.Clear();
                    _transportCard.OnReturnToMenu?.Invoke();
                    Navigation();
                    break;
            }

            ReturnToMenu();
        }

        public void ReturnToMenu()
        {
            Console.WriteLine("Вернуться в меню - 1");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (number)
            {
                case 1:
                    Navigation();
                    break;
                default:
                    _transportCard.OnReturnToMenu?.Invoke();
                    Navigation();
                    break;
            }
        }
    }
}