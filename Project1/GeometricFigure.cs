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

        //Свойства
        public double SideA => _sideA;

        public double SideB => _sideB;

        public double SideC => _sideC;

        public double Square => Math.Sqrt(Perimeter / 2(Perimeter / 2 - SideA) * (Perimeter / 2 - SideB) * (Perimeter / 2 - SideC));

        public double Perimeter => SideA + SideB + SideC;

        //Конструкторы
        public GeometricFigure(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        
    }
}