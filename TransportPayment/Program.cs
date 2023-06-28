using System;
using TransportPayment;


namespace TransportPayment
{
    class Program
    {
        private static NavigationMenu _navigationMenu = new NavigationMenu();
        static void Main(string[] args)
        {
            _navigationMenu.Navigation();
        }
    }
}