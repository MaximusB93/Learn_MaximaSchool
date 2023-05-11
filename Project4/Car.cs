namespace Project4
{
    public class Car : Transport
    {
        //Свойства
        public virtual BrandCar Brand { get; }
        public virtual string Color { get; set; }
        public int Year { get; }
        public virtual string Transmission { get; }
        public virtual string Engine { get; }

        //Конструктор
        public Car(BrandCar brand, string color, int year, string transmission, string engine)
        {
            Brand = brand;
            Color = color;
            Year = year;
            Transmission = transmission;
            Engine = engine;
        }
    }

    public enum BrandCar
    {
        Acura,
        Alfa_Romeo,
        Aston_Martin,
        Audi,
        Aurus,
        Bentley,
        BMW,
        Brilliance,
        Bugatti,
        Buick,
        BYD,
        Cadillac,
        Changan,
        Chery,
        Chevrolet,
        Chrysler,
        Citroen,
        Daewoo,
        Daihatsu,
        Datsun,
        Dodge,
        DongFeng,
        DS
    }
}