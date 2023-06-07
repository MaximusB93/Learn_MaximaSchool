using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using GeometryLibrary.Figures;
using GeometryLibrary.Figures.Abstract;

namespace GeometryCalculator
{
    /*abstract class Obj<T, K> where K : struct
    {
        public T Id { get; set; }

        public K Data { get; set; }

        public Obj(T id, K data)
        {
            Id = id;
            Data = data;
        }

        public virtual string  Format()
        {
            return $"{Data} + {Id}";
        }
    }

    class MyClass1<T> : Obj<T, string>
    {
        private byte _a;

        public MyClass1(T id, string data, byte a) : base(id, data)
        {
            _a = a;
        }

        public override string Format()
        {
            return $"{Id} + {Data} + {_a}";
        }
    }

    class MyClass2<K> : Obj<int, K>
    {
        private byte _a;

        public MyClass2(int id, K data, byte a) : base(id, data)
        {
            _a = a;
        }

        public override string Format()
        {
            return $"{Id} + {Data} + {_a} + привет";
        }
    }*/

    class Program
    {
        public static double Diving(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Ошибочка");
            }

            return a / b;
        }

        public static void Main()
        {
            int a = 10;
            int b = 0;
            try
            {
                /*double result = Diving(10, 0);*/
                /*int result = a / b;*/
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
            /*Obj<int, string> [] me1 = {new MyClass1<int>(1,"Бла",1), new MyClass2<string>(1,"Бла",1)};

            foreach (var me in me1)
            {
                Console.WriteLine(me.Format());
            }
            
             MyClass1<int> myclass1 = new MyClass1<int>(1,"Бла",1);

            Console.WriteLine(myclass1.Format());*/


            /*var tr1 = new Triangle<string>(1, 2, 3, "99");
            var tr3 = new Triangle<int>(1, 2, 3, 99);

            var tr2 = new Triangle<T>[] { tr1, tr3 };


            IFigure[] figures =
            {
                new Circle(4, 1),
                new Square(55, 3),
                new Circle(3, 5),
                new Square(33, 8),
                new Triangle(10, 8, 9, 4),
                new Cube(5, 50)
            };

            double summ = 0;

            foreach (var figure in figures)
            {
                if (figure is IThreeDimensionFigures threeDimensionFigures)
                {
                    summ += threeDimensionFigures.Volume;
                    Console.WriteLine(summ);
                }
            }*/

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

            /*foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.GetTitle()}: {figure.GetAnglesCount()}");
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
        }*/
        }
    }
}