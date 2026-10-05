namespace Refactoring.Part1.OrderProcessor.Interface
{
    public interface IEmailSender
    {
        void Send(string to, string body);
    }
}
