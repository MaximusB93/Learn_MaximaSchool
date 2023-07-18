using System.Collections.Generic;

namespace Products
{
    public class Localization
    {
        public Dictionary<string, Dictionary<string, string>> GetLocalization()
        {
            var dictionaryLoc = new Dictionary<string, Dictionary<string, string>>()
            {
                {
                    "item_milk", new Dictionary<string, string>()
                    {
                        { "ru", "Молоко" },
                        { "en", "Milk" }
                    }
                },
                {
                    "item_cheese", new Dictionary<string, string>()
                    {
                        { "ru", "Сыр" },
                        { "en", "Cheese" }
                    }
                },
                {
                    "item_curd", new Dictionary<string, string>()
                    {
                        { "ru", "Творог" },
                        { "en", "Curd" }
                    }
                },
                {
                    "item_bananas", new Dictionary<string, string>()
                    {
                        { "ru", "Бананы" },
                        { "en", "Bananas" }
                    }
                },
                {
                    "item_apples", new Dictionary<string, string>()
                    {
                        { "ru", "Яблоки" },
                        { "en", "Apples" }
                    }
                },
                {
                    "item_pears", new Dictionary<string, string>()
                    {
                        { "ru", "Груши" },
                        { "en", "Pears" }
                    }
                },
                {
                    "item_orange", new Dictionary<string, string>()
                    {
                        { "ru", "Апельсины" },
                        { "en", "Orange" }
                    }
                },
                {
                    "item_cucumbers", new Dictionary<string, string>()
                    {
                        { "ru", "Огурцы" },
                        { "en", "Cucumbers" }
                    }
                },
                {
                    "item_tomatoes", new Dictionary<string, string>()
                    {
                        { "ru", "Томаты" },
                        { "en", "Tomatoes" }
                    }
                },
                {
                    "item_pepper", new Dictionary<string, string>()
                    {
                        { "ru", "Перец" },
                        { "en", "Pepper" }
                    }
                }
            };
            return dictionaryLoc;
        }
    }
}