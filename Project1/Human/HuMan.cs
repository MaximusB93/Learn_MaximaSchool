using System;
using System.Drawing;

namespace Project1
{
    public class HuMan
    {
        //Поля класса
        private string _name;
        private byte _age;
        private int _height;
        private int _wheight;
        private Color _eyecolor;
        private Car _car;


        //Свойства
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

        //Конструкторы
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
            if (!CheckingHumanParameters(age, height, wheight))
            {
                throw new Exception("Некорректные данные");
            }

            HumanFabric.Number++;
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


        /// <summary>
        /// Проверка параметров человека
        /// </summary>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="wheight"></param>
        /// <returns></returns>
        private bool CheckingHumanParameters(byte age, int height, int wheight)
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