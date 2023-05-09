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
            Figure[] figures = { new Circle(4,1), new Square(55,3), new Circle(3,5), new Square(33,8), new Triangle(10,8,9,4) };
            /*Console.WriteLine("Площадь");
            Console.WriteLine(CalculateAreas(figures));
            Console.WriteLine("Периметр");
            Console.WriteLine(CalculatePerimeter(figures));*/

            /*List<Figure> figures = new List<Figure>();
            int number = 0;
            while (true)
            {
                string str = Console.ReadLine();

                if (str == "EXIT")
                {
                    
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
                            figure = new Circle(values[0],number);
                            break;
                        case FigureType.Square:
                            figure = new Square(values[0],number);
                            break;
                        case FigureType.Triangle:
                            figure = new Triangle(values[0], values[1], values[2],number);
                            break;
                        default:
                            throw new Exception();
                    }

                    number++;  
                    figures.Add(figure);
                    
                }
                else
                {
                    Console.WriteLine("Нет такой фигуры");
                }
            }*/

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetTitle());
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