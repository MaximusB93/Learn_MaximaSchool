using System;

namespace GetMails
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Human();
            

            man.GetMailEvent += (sender, eventArgs) => Console.WriteLine($"1Письмо получено - {eventArgs.Mail}");
            man.GetMailEvent += (sender, eventArgs) => Console.WriteLine($"2Письмо получено - {eventArgs.Mail}");
            man.GetMailEvent += (sender, eventArgs) => Console.WriteLine($"3Письмо получено - {eventArgs.Mail}");
            man.GetMailEvent += (sender, eventArgs) => Console.WriteLine($"4Письмо получено - {eventArgs.Mail}");
            man.AddMail(new Mail("Текст","Адрес","Автор"));
            man.
        }
    }
}