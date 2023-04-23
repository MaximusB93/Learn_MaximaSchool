using System;
using System.Drawing;

namespace Project1
{
    public class Car
    {
        //Поля класса
        private Color _color;  
        private int _year;
        private double _mileage;
        private double _fuel;

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
            return
                $"{nameof(_color)}: {_color}, {nameof(_year)}: {_year}, {nameof(_mileage)}: {_mileage}, {nameof(_fuel)}: {_fuel}";
        }
    }
}