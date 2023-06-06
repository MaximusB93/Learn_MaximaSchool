using System;

namespace CreatureCarAndHuman
{
    public class City
    {
        /// <summary>
        /// Названия городов
        /// </summary>
        public enum NameCity
        {
            Лондон,
            Москва,
            Челябинск,
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