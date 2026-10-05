namespace Refactoring.Part1.Notifications.Interface
{
    public interface INotificationChannel
    {
        void Send(string to, string message);
    }
}
