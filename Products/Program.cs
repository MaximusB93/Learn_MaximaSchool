using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.XPath;
using Newtonsoft.Json;
using Products.Discounts;

namespace Products
{
    public class Program
    {
        public static void Main()
        {
            //Создаем продукт
            Product product = new Product(50, "Milk", "Молочная продукция", new InventoryItem(500, "MSK"));

            TransformationJson transformationJson = new TransformationJson();
            //Конвертируем в JSON
            string json = transformationJson.InJson(product);

            //Конвертируем из JSON в класс Product
            Product productFromJson = transformationJson.FromJson(json);
        }
    }
}