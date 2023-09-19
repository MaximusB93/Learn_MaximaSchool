using System.Collections.Generic;

namespace Products.Discounts
{
    public class DiscountsQuantityProducts : IDiscounts
    {
        private Dictionary<decimal, decimal> discountLevels = new Dictionary<decimal, decimal>
        {
            { 10, 0.80m },
            { 5, 0.95m },
            { 3, 0.97m }
        };

        public decimal CalculatorDiscounts(decimal sum, int countProduct)
        {
            foreach (var kvp in discountLevels)
            {
                if (countProduct >= kvp.Key)
                {
                    return sum * kvp.Value;
                }
            }

            return sum;
        }
    }
}