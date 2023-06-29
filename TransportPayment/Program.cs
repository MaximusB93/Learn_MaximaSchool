using System;
using TransportPayment;


namespace TransportPayment
{
    class Program
    {
        private static NavigationMenu _navigationMenu = new NavigationMenu();
        private static Notifications _notifications = new Notifications();

        static void Main(string[] args)
        {
            _notifications.Active();
            _navigationMenu.Navigation();
        }
    }
}