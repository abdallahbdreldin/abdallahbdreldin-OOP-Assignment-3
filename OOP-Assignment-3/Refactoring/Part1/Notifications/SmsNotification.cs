using Refactoring.Part1.Notifications.Interface;

namespace Refactoring.Part1.Notifications
{
    public class SmsNotification : INotificationChannel
    {
        public void Send(string to, string message) =>
            Console.WriteLine($"[sms] {to}: {message}");
    }
}
