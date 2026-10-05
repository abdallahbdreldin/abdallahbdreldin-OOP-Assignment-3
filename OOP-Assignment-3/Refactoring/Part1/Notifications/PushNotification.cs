using Refactoring.Part1.Notifications.Interface;

namespace Refactoring.Part1.Notifications
{
    public class PushNotification : INotificationChannel
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[push] {to}: {message}");
    }
}
