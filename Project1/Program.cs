using System;
using System.Runtime.CompilerServices;


namespace Project1
{
    internal class Program
    {
        public static void Main()
        {
            //Начальные характеристики автомобиля
            Car car = new Car(Car.CarColor.Black, 2020, 45000, 12);

            Console.WriteLine($"Текущий объем топлива: {car.CurrentFuel()} л");
            Console.WriteLine($"Приехали на заправку, на сколько литров заправимся?");
            car.RefuelCar(Double.Parse(Console.ReadLine()));
            Console.WriteLine($"Новый объем топлива: {car.CurrentFuel()} л");
            Console.WriteLine($"Куда поедем?");
            for (int i = 0; i < Enum.GetNames(typeof(City)).Length; i++)
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(City), i)}");
            int NumberCity = Int32.Parse(Console.ReadLine()) - 1;
            (double, City) response = car.Drive(NumberCity);
            Console.WriteLine($"Доехали до {response.Item2}, у нас осталось {response.Item1} л топлива");
        }
    }
}