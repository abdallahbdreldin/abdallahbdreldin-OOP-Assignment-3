using Refactoring.Part1.Notifications;
using Refactoring.Part1.Notifications.Interface;
using Refactoring.Part1.OrderProcessor;
using Refactoring.Part1.ShippingCostCalculator;

namespace Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ==========================
            // Shipping
            // ==========================

            var aramex = new AramexShippingCostCalculator();
            Console.WriteLine($"Aramex 2kg => {aramex.Calculate(2)}");

            var fedEx = new FedExShippingCostCalculator();
            Console.WriteLine($"FedEx 2kg  => {fedEx.Calculate(2)}");

            var ups = new UPSShippingCostCalculator();
            Console.WriteLine($"UPS 2kg    => {ups.Calculate(2)}");

            Console.WriteLine();


            // ==========================
            // Order Processing
            // ==========================

            var orderProcessor = new OrderProcessor(
                new SqlOrderRepository(),
                new SmtpEmailSender());

            orderProcessor.Process(1001, "customer@example.com");

            Console.WriteLine();


            // ==========================
            // Notifications
            // ==========================

            INotificationChannel email = new EmailNotification();

            email.Send("customer@example.com", "Your order ships tomorrow");


            INotificationChannel urgentEmail = new UrgentNotification(email);

            urgentEmail.Send("customer@example.com", "Your order ships tomorrow");

            INotificationChannel scheduledUrgentEmail =
                new ScheduledNotification(
                    urgentEmail,
                    DateTime.Today.AddHours(18));

            scheduledUrgentEmail.Send("customer@example.com", "Your order ships tomorrow");

            Console.WriteLine();

            INotificationChannel sms = new SmsNotification();

            sms.Send("+201000000000", "OTP 4821");

            INotificationChannel urgentSms = new UrgentNotification(sms);

            urgentSms.Send("+201000000000", "OTP 4821");

            INotificationChannel scheduledUrgentSms =
                new ScheduledNotification(
                    urgentSms,
                    DateTime.Today.AddHours(18));

            scheduledUrgentSms.Send("+201000000000", "OTP 4821");

            Console.WriteLine();


            // ==========================
            // New Notification Channel - R6
            // ==========================

            INotificationChannel push = new PushNotification();

            push.Send("user-123", "You have a new order");

            INotificationChannel scheduledUrgentPush =
                new ScheduledNotification(
                    new UrgentNotification(push),
                    DateTime.Today.AddHours(20));

            scheduledUrgentPush.Send("user-123", "Your order ships tomorrow");
        }
    }
}
