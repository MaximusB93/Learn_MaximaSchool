namespace TransportPayment
{
    class StartedProgram
    {
        static void Main()
        {
            var card = new TransportCard();
            new Notifications(card).Subscribe();
            new NavigationMenu(card).Navigation();
            
            //_navigationMenu.Navigation();
        }
    }
}