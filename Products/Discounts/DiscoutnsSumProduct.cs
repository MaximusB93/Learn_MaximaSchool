using System.Collections.Generic;

namespace Products.Discounts
{
    public class DiscoutnsSumProduct : IDiscounts
    {
        private Dictionary<decimal, decimal> discountLevels = new Dictionary<decimal, decimal>
        {
            { 1000m, 0.80m },
            { 500m, 0.95m },
            { 200m, 0.97m }
        };

        public decimal CalculatorDiscounts(decimal sum, int countProduct)
        {
            foreach (var kvp in discountLevels)
            {
                if (sum >= kvp.Key)
                {
                    return sum * kvp.Value;
                }
            }

            return sum;
        }
    }
}