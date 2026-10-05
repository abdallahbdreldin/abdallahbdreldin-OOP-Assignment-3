using Refactoring.Part1.OrderProcessor.Interface;

namespace Refactoring.Part1.OrderProcessor
{
    public class SqlOrderRepository : IOrderRepository
    {
        public void Save(int orderId, DateTime processedAt) =>
            Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
    }
}
