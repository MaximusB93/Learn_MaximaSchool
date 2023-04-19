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
            Console.WriteLine($"Заправились на {refuel} л");
            return _fuel += refuel;
        }

        public (double, City) Drive(int NumberCity)
        {
            switch ((City)NumberCity)
            {
                case City.Лондон:
                    return (_fuel - 15, (City)NumberCity);
                case City.Москва:
                    return (_fuel - 10, (City)NumberCity);
                case City.Челябинск:
                    return (_fuel - 8, (City)NumberCity);
            } 

            return (_fuel - 0, (City)NumberCity);
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