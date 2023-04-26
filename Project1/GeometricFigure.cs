using System;

namespace Project1
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class GeometricFigure
    {
        //Поля класса
        private double _sideA;
        private double _sideB;
        private double _sideC;

        private double _cornerA;
        private double _cornerB;
        private double _cornerC;

        private double _square;
        private double _perimeter;
        private double _semiperimeter;

        //Свойства
        public double SideA => _sideA;

        public double SideB => _sideB;

        public double SideC => _sideC;

        /// <summary>
        /// Площадь треугольника по формуле Герона
        /// </summary>
        public double Square =>
            Math.Sqrt(Semiperimeter * (Semiperimeter - SideA) * (Semiperimeter - SideB) * (Semiperimeter - SideC));

        public double Perimeter => SideA + SideB + SideC;

        public double Semiperimeter => Perimeter / 2;

        //Конструкторы
        public GeometricFigure(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
    }
}