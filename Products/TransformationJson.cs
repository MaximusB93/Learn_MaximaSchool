using System;
using Newtonsoft.Json;

namespace Products
{
    public class TransformationJson
    {
        //Конвертируем в JSON
        public string InJson(Product product)
        {
            string json = JsonConvert.SerializeObject(product);
            return json;
        }

        //Конвертируем из JSON в класс Product
        public Product FromJson(string json)
        {
            Product productFromJson = JsonConvert.DeserializeObject<Product>(json);
            return productFromJson;
        }
    }
}