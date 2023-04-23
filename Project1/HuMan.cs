using System;
using System.Drawing;

namespace Project1
{
    public class HuMan
    {
        //Поля класса

        //Вынести в другой класс
        private static int _number;

        private string _name;
        private byte _age;
        private int _height;
        private int _wheight;
        private Color _eyecolor;
        private Car _car;


        //Свойства

        //Вынести в другой класс
        public static int Number => _number;


        public Car Car => _car;
        

        public byte Age
        {
            get => _age;    

            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                
            }
        }


        public HuMan(byte age)
        {
            _age = age;
        }

        public HuMan()
        {
            _name = "Михаил";
        }

        public HuMan(string name, byte age, int height, int wheight)
        {
            if (!Check(age, height, wheight))
            {
                throw new Exception("Некорректные данные");
            }

            _number++;
            _name = name;
            _age = age;
            _height = height;
            _wheight = wheight;
        }

        public HuMan(string name, byte age, int height, int wheight, Color eyecolor)
            : this(name, age, height, wheight)
        {
            _eyecolor = eyecolor;
        }

        public HuMan(string name, byte age, int height, int wheight, Color eyecolor, Car car)
            : this(name, age, height, wheight, eyecolor)
        {
            _car = car;
        }

        //Вынести в другой класс
        /// <summary>
        /// Счетчик
        /// </summary>
        /// <returns></returns>
        public static int GetNumber()
        {
            return _number;
        }
        
        /// <summary>
        /// Проверка
        /// </summary>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="wheight"></param>
        /// <returns></returns>
        private bool Check(byte age, int height, int wheight)
        {
            if (age > 120)
                return false;
            if (height > 300 || height <= 0)
                return false;
            if (wheight <= 0)
                return false;

            return true;
        }

        /// <summary>
        /// Данные человека
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{_name}, {_age} лет, рост {_height}";
        }
    }
}