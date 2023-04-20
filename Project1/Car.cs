using System;

namespace Project1
{
    public class Car
    {
        public enum CarColor
        {
            Blue,
            Red,
            White,
            Black
        }
        
        private CarColor _color;
        private int _year;
        private double _mileage;
        private double _fuel;
        
        public Car(CarColor color, int year, double mileage, double fuel)
        {
            _color = color;
            _year = year;
            _mileage = mileage;
            _fuel = fuel;
        }

        public double CurrentFuel()
        {
            return _fuel;
        }

        public double RefuelCar(double refuel)
        {
            return _fuel += refuel;
        }

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

        public void GoMileage()
        {
            _mileage += 1;
        }

        public int AgeOfCar()
        {
            return DateTime.Now.Year - _year;
        }

        public override string ToString()
        {
            return
                $"{nameof(_color)}: {_color}, {nameof(_year)}: {_year}, {nameof(_mileage)}: {_mileage}, {nameof(_fuel)}: {_fuel}";
        }
    }
}