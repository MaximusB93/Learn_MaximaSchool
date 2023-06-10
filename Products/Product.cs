namespace Products
{
    public class Product
    {
        public int Price { get; }
        public string Name { get; }

        public Product(int price, string name)
        {
            Price = price;
            Name = name;
        }
    }
}