using System.Collections.Generic;
using Newtonsoft.Json;

namespace Products
{
    public class Product
    {
        public int Price { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public InventoryItem InventoryItem { get; set; }

        [JsonConstructor]
        public Product(int price, string title, string category, InventoryItem inventoryItem)
        {
            Price = price;
            Title = title;
            Category = category;
            InventoryItem = inventoryItem;
        }
        public Product(int price, string title)
        {
            Price = price;
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title}: {Price:C0}";
        }
    }
    
    public class InventoryItem
    {
        public InventoryItem(int quantity, string location)
        {
            Quantity = quantity;
            Location = location;
        }

        public int Quantity { get; set; }
        public string Location { get; set; }
    }
}