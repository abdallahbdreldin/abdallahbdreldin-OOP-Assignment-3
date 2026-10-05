using Refactoring.Part1.ShippingCostCalculator.Interface;

namespace Refactoring.Part1.ShippingCostCalculator
{
    public class FedExShippingCostCalculator : IShippingCostCalculator
    {
        public decimal Calculate(decimal weightKg)
            => weightKg * 15m;
    }
}
