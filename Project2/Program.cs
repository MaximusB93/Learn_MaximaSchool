using System;

namespace Project2
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Figure() { new Circle(10), new Square(10) };
        }
    }
}