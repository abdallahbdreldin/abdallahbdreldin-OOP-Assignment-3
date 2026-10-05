using Refactoring.Part1.ShippingCostCalculator.Interface;

namespace Refactoring.Part1.ShippingCostCalculator
{
    public class DHLShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(decimal weightKg)
            => weightKg * 18m;
    }
}
