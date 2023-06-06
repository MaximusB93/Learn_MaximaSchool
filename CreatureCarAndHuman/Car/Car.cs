using System;
using System.Drawing;

namespace CreatureCarAndHuman
{
    public class Car
    {
        //Поля класса
        private readonly BrandCar _brandCar;
        private Color _color;
        private int _year;
        private double _mileage;
        private double _fuel;
        private double _averageFuelConsumption;
        private double _powerReserve;

        //Свойства
        public BrandCar BrandCar => _brandCar;
        public Color Color => _color;
        public int Year => _year;
        public double Mileage => _mileage;

        public double Fuel
        {
            get => _fuel;
            set
            {
                if (_fuel > 45)
                    _fuel = 45;

                _fuel = value;
            }
        }

        public double AverageFuelConsumption => _averageFuelConsumption;

        public double PowerReserve => _averageFuelConsumption * _fuel;


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Car()
        {
            _color = Color.Aqua;
            _year = 2000;
            _mileage = 254921;
            _fuel = 12;
            _averageFuelConsumption = 8.2;
            GoMileage();
        }

        /// <summary>
        /// Конструктор полей
        /// </summary>
        /// <param name="color"></param>
        /// <param name="year"></param>
        /// <param name="mileage"></param>
        /// <param name="fuel"></param>
        public Car(Color color, int year, double mileage, double fuel)
        {
            _color = color;
            _year = year;
            _mileage = mileage;
            _fuel = fuel;
        }

        /// <summary>
        /// Конструктор поля brandCar + this
        /// </summary>
        /// <param name="brandCar"></param>
        /// <param name="color"></param>
        /// <param name="year"></param>
        /// <param name="mileage"></param>
        /// <param name="fuel"></param>
        public Car(BrandCar brandCar, Color color, int year, double mileage, double fuel)
            : this(color, year, mileage, fuel)
        {
            _brandCar = brandCar;
        }

        //Методы
        /// <summary>
        /// Количество топлива
        /// </summary>
        /// <returns></returns>
        public double CurrentFuel()
        {
            return _fuel;
        }

        /// <summary>
        /// Запраляемся топливом
        /// </summary>
        /// <returns></returns>
        public double RefuelCar(double refuel)
        {
            if (_fuel + refuel > 45)
            {
                Console.WriteLine(
                    $"Общий объем бака не может быть более 45 л, сейчас вы можете заправиться max на {45 - _fuel} л");
            }

            return _fuel += refuel;
        }

        /// <summary>
        /// Вычисление расхода топлива исходя из города
        /// </summary>
        /// <param name="NumberCity"></param>
        /// <returns></returns>
        public (double, City.NameCity) Drive(int NumberCity)
        {
            switch ((City.NameCity)NumberCity)
            {
                case City.NameCity.Лондон:
                    return (_fuel - 15, (City.NameCity)NumberCity);
                case City.NameCity.Москва:
                    return (_fuel - 10, (City.NameCity)NumberCity);
                case City.NameCity.Челябинск:
                    return (_fuel - 8, (City.NameCity)NumberCity);
            }

            return (_fuel - 0, (City.NameCity)NumberCity);
        }

        /// <summary>
        /// Пробег +1
        /// </summary>
        public void GoMileage()
        {
            _mileage += 1;
        }

        /// <summary>
        /// Возраст авто
        /// </summary>
        /// <returns></returns>
        public int AgeOfCar()
        {
            return DateTime.Now.Year - _year;
        }

        /// <summary>
        /// Данные авто
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return $"{nameof(BrandCar)}: {BrandCar}, {nameof(Color)}: {Color}, {nameof(Year)}: {Year}, {nameof(Mileage)}: {Mileage}, {nameof(Fuel)}: {Fuel}, {nameof(AverageFuelConsumption)}: {AverageFuelConsumption}, {nameof(PowerReserve)}: {PowerReserve}";
        }
    }
}