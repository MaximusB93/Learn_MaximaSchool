using System;

namespace TransportPayment
{
    public class Transport
    {
        private static NavigationMenu _navigationMenu;
        private static Notifications _notifications;

        public string TypeTransport { get; set; }
        public decimal Fare { get; set; }

        private readonly string[] _typeTransport =
        {
            "Bus",
            "Train",
            "ElectricTrain",
            "Taxi"
        };

        public (decimal, string) GetTransport()
        {
            Console.WriteLine("Выберите транспорт:");

            for (int i = 0; i < _typeTransport.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_typeTransport[i]}");
            }

            int selectingItem = int.Parse(Console.ReadLine() ?? string.Empty)-1;

            switch (selectingItem)
            {
                case 0:
                    Fare = 30;
                    break;
                case 1:
                    Fare = 100;
                    break;
                case 2:
                    Fare = 50;
                    break;
                case 3:
                    Fare = 170;
                    break;
                default:
                    Console.Clear();
                    _notifications.NotifyReturnToMenu();
                    _navigationMenu.Navigation();
                    break;
            }

            TypeTransport = _typeTransport[selectingItem];
            return (Fare, TypeTransport);
        }
    }
}