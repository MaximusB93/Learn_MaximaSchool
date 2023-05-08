using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Project2.Figures;

namespace Project2
{
    class Program
    {
        static void Main()
        {
            /*Figure[] figures = { new Circle(4), new Square(55), new Circle(3), new Square(33) };
            Console.WriteLine("Площадь");
            Console.WriteLine(CalculateAreas(figures));
            Console.WriteLine("Периметр");
            Console.WriteLine(CalculatePerimeter(figures));*/

            List<Figure> figures = new List<Figure>();

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "EXIT")
                {
                    Console.WriteLine(CalculateAreas(figures));
                    break;
                }

                string[] arguments = str.Split(":");
                string title = arguments[0];

                if (Enum.TryParse(typeof(FigureType), title, true, out var temp))
                {
                    FigureType figureType = (FigureType)temp;
                    Figure figure = null;

                    string[] strValue = arguments[1].Split(",");
                    double[] values = new double [strValue.Length];

                    for (int i = 0; i < strValue.Length; i++)
                    {
                        values[i] = Double.Parse(strValue[i]);
                    }

                    switch (figureType)
                    {
                        case FigureType.Circle:
                            figure = new Circle(values[0]);
                            break;
                        case FigureType.Square:
                            figure = new Square(values[0]);
                            break;
                        case FigureType.Triangle:
                            figure = new Triangle(values[0], values[1], values[2]);
                            break;
                        default:
                            throw new Exception();
                    }
                    
                    figures.Add(figure);
                    
                }
                else
                {
                    Console.WriteLine("Нет такой фигуры");
                }
            }
            
        }

        
        

        static string CalculateAreas(List<Figure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Area:F1}\r\n";
                sb.Append(str);
            }

            return sb.ToString();
        }

        static string CalculatePerimeter(List<Figure> figures)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var figure in figures)
            {
                var str = $"{figure.GetTitle()}:{figure.Perimeter:F1}\r\n";
                sb.Append(str);
            }

            return sb.ToString();
        }
    }
}