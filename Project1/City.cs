using System;

namespace Project1
{
    public class City
    {
        /// <summary>
        /// Названия городов
        /// </summary>
        public enum NameCity
        {
            London,
            Moscow,
            Chelyabinsk
        }

        private NameCity nameCity;


        /// <summary>
        /// Перебор городов в цикле
        /// </summary>
        public static void IteratingListCity()
        {
            for (int i = 0; i < Enum.GetNames(typeof(NameCity)).Length; i++)
                Console.WriteLine($"{i + 1}. {Enum.GetName(typeof(City.NameCity), i)}");
        }
    }
}