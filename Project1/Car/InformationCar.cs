using System;
using System.Drawing;

namespace Project1
{
    public class InformationCar
    {
        public static Car CreatingCar()
        {
            //Начальные характеристики автомобиля
            Car car = new Car(BrandCar.Audi, Color.Black, 2020, 45000, 12);
            return car;
        }

        public static void Start()
        {
            ViewDrive();
            ViewAboutCar();
            ViewRefuel();
        }
        
        /// <summary>
        /// Вывод на консоль
        /// </summary>
        public static void ViewAboutCar()
        {
            Console.WriteLine($"Начальные характеристики автомобиля - {CreatingCar().ToString()}");
            Console.WriteLine($"Текущий объем топлива: {CreatingCar().CurrentFuel()} л");
        }

        private static void ViewRefuel()
        {
            Console.WriteLine("Приехали на заправку, на сколько литров заправимся?");
            CreatingCar().RefuelCar(Double.Parse(Console.ReadLine()));

            Console.WriteLine($"Новый объем топлива: {CreatingCar().CurrentFuel()} л");
            Console.WriteLine("Куда поедем?");
            City.IteratingListCity();
        }

        private static void ViewDrive()
        {
            (double, City.NameCity) response = CreatingCar().Drive(InputInformationCar());
            Console.WriteLine($"Доехали до {response.Item2}, у нас осталось {response.Item1} л топлива");
        }

        /// <summary>
        /// Ввод информации
        /// </summary>
        /// <returns></returns>
        public static int InputInformationCar()
        {
            int NumberCity = Int32.Parse(Console.ReadLine()) - 1;
            return NumberCity;
        }
    }
}