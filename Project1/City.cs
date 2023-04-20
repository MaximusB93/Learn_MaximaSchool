using System;

namespace Project1
{
    public class City
    {
        public enum NameCity
        {
            Лондон,
            Москва,
            Челябинск,
        }

        private NameCity nameCity;

        public static void IteratingListCity()
        {
            for (int i = 0; i < Enum.GetNames(typeof(NameCity)).Length; i++)
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(City.NameCity), i)}");
        }
    }
}