using Refactoring.Part1.ShippingCostCalculator.Interface;

namespace Refactoring.Part1.ShippingCostCalculator
{
    public class AramexShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(decimal weightKg)
            => weightKg * 10m;
    }
}
