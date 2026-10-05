using Refactoring.Part1.OrderProcessor.Interface;

namespace Refactoring.Part1.OrderProcessor
{
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(string to, string body) =>
            Console.WriteLine($"[SMTP] to={to} body={body}");
    }
}
