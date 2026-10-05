using Refactoring.Part1.Notifications.Interface;

namespace Refactoring.Part1.Notifications
{
    public class UrgentNotification : INotificationChannel
    {
        private readonly INotificationChannel _channel;

        public UrgentNotification(INotificationChannel channel)
        {
            _channel = channel;
        }

        public void Send(string to, string message) =>
            _channel.Send(to, $"[URGENT] {message}");
    }
}
