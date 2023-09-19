using System.Collections.Generic;

namespace Products.Discounts
{
    public interface IDiscounts
    {
        decimal CalculatorDiscounts(decimal sum, int countProduct);
    }
}