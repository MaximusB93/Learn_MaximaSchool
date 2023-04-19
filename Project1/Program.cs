using System;
using System.Runtime.CompilerServices;

namespace Project1
{
    internal class Program
    {
        public static void Main()
        {
            Car car = new Car(Car.CarColor.Black, 2020, 45000, 12);


            Console.WriteLine($"Текущий объем топлива: {car.CurrentFuel()} л");
            Console.WriteLine($"Приехали на заправку, на сколько литров заправимся?");
            car.RefuelCar(Double.Parse(Console.ReadLine()));
            Console.WriteLine($"Новый объем топлива: {car.CurrentFuel()} л");
            car.FuelConsumption();




            /*/*Console.WriteLine($"1. {car}");#1#
            car.GoMileage();
            Console.WriteLine(car.ToString());*/
        }
    }
}