namespace Refactoring.Part1.OrderProcessor.Interface
{
    public interface IOrderRepository
    {
        void Save(int orderId, DateTime processedAt);
    }
}
