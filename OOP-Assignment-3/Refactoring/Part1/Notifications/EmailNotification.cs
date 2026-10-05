using Refactoring.Part1.Notifications.Interface;

namespace Refactoring.Part1.Notifications
{
    public class EmailNotification : INotificationChannel
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[email] {to}: {message}");
    }
}
