using System.Collections.Generic;
using System.Linq;

namespace Products
{
    public class FilteringCard
    {
        public List<ProductCard> listCard { get; }

        public FilteringCard(List<ProductCard> listCard)
        {
            this.listCard = listCard;
        }

        private List<ProductCard> GetSumCardMore100()
        {
            // Выбрать такие корзины,в которых сумма всех продуктов больше 500
            var sumCardMore100 = listCard.Where(x => x.Products.Sum(x => x.Price) > 500)
                .ToList();
            return sumCardMore100;
        }

        private List<int> GetProductMaxPriceInCard()
        {
            // Выбрать для каждой корзины продукт с максимальной ценой в рамках данной корзины
            var productMaxPriceInCard = listCard.Select(x => x.Products.Max(x => x.Price))
                .ToList();
            return productMaxPriceInCard;
        }

        private List<int> GetSums()
        {
            // Посчитать сумму всех продуктов в рамках каждой корзины
            var sums = listCard.Select(x => x.Products.Sum(x => x.Price))
                .ToList();
            return sums;
        }

        private List<Product> GetCardMoreFourProducts()
        {
            // Выбрать такие корзины, у которых более 4 продуктов 
            var cardMoreFourProducts = listCard.Where(x => x.Products.Count > 3)
                .SelectMany(x => x.Products)
                .ToList();
            return cardMoreFourProducts;
        }

        private List<Product> GetProductsTitleMore5AndPriceMore60()
        {
            // Выбрать такие продукты, у которых название длинее 5 символов и цена больше 60
            var productsTitleMore5AndPriceMore60 = listCard.SelectMany(x => x.Products)
                .Where(x => x.Price > 60 && x.Title.Length > 5)
                .ToList();
            return productsTitleMore5AndPriceMore60;
        }

        private List<Product> GetSumCardPrice()
        {
            // Выбрать продукты из всех корзин, у которых цена в интервале от 10 до 100
            var sumCardPrice = listCard.SelectMany(x => x.Products)
                .Where(x => x.Price > 10 && x.Price < 100)
                .ToList();
            return sumCardPrice;
        }

        private int GetSumAllPrice()
        {
            // Посчитать сумму всех продуктов для всех корзин суммарно
            var sumAllPrice = listCard.SelectMany(x => x.Products)
                .Sum(x => x.Price);
            return sumAllPrice;
        }
    }
}