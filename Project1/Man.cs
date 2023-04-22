using System;

namespace Project1
{
    public class Man
    {
        public enum Color
        {
            Blue,
            Green,
            Brown,
            Brown2
        }

        private static int _number;

        public static int GetNumber()
        {
            return _number;
        }

        private string _name;
        private byte _age;
        private int _height;
        private int _wheight;
        private Color _eyecolor;

        public Man(string name, byte age, int height, int wheight)
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

        public Man(string name, byte age, int height, int wheight, Color eyecolor)
            : this(name, age, height, wheight)
        {
            _eyecolor = eyecolor;
        }


        public static int Number => _number;


        public byte Age
        {
            get => _age;
            set => _age = value;
        }

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


        public string Print()
        {
            return $"{_name}, {_age} лет, рост {_height}";
        }
    }
}