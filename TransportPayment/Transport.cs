using System;

namespace TransportPayment
{
    public class Transport
    {
        private readonly string[] _typeTransport =
        {
            "Bus",
            "Train",
            "ElectricTrain",
            "Taxi"
        };

        public decimal GetTransport()
        {
            decimal fare = 0;
            Console.WriteLine("Выберите транспорт:");

            for (int i = 0; i < _typeTransport.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_typeTransport[i]}");
            }

            int selectingItem = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (selectingItem)
            {
                case 1:
                    return fare = 30;
                    break;
                case 2:
                    return fare = 100;
                    break;
                case 3:
                    return fare = 50;
                    break;
                case 4:
                    return fare = 170;
                    break;
                default:
                    return fare;
                    break;
            }
        }
    }
}