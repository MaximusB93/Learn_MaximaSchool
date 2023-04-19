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

        public enum City
        {
            Лондон = 0,
            Москва= 1,
            Челябинск= 2,
        }


        private City city;
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

        public void FuelConsumption()
        {
            Console.WriteLine($"Куда поедем?");
            for (int i = 0; i < Enum.GetNames(typeof(City)).Length; i++)
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(City), i)}");

            switch (city)
            {
                case 0:
                    Console.WriteLine(0 ? 1 ? _fuel - 23:_fuel - 23);
                    break;
                case 1:
                    Console.WriteLine(_fuel - 15);
                    break;
                case 2:
                    Console.WriteLine(_fuel - 10);
                    break;
            }
        }

        /*public void FuelConsumption()
        {

            switch (City)
            {
                case 0:
                    Console.WriteLine(_fuel - 23);
                    break;
            }

        }*/

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