using System;
using System.Drawing;

namespace CreatureCarAndHuman
{
    public class InformationCar
    {
        /// <summary>
        /// Вывод на консоль
        /// </summary>
        public static void OutputInformationCar()
        {
            //Начальные характеристики автомобиля
            Car car = new Car(Color.Black, 2020, 45000, 12);
            Console.WriteLine($"Начальные характеристики автомобиля - {car.ToString()}");
            Console.WriteLine($"Текущий объем топлива: {car.CurrentFuel()} л");
            Console.WriteLine("Приехали на заправку, на сколько литров заправимся?");
            car.RefuelCar(Double.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Новый объем топлива: {car.CurrentFuel()} л");
            Console.WriteLine("Куда поедем?");
            City.IteratingListCity();
            
            (double, City.NameCity) response = car.Drive(InputInformationCar());
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