using Penguin.Email.Abstractions.Interfaces;

namespace Penguin.Email.Abstractions.Extensions
{
    public static class ISendMailExtensions
    {
        public static void TrySend(this ISendMail sender, IEmailMessage message)
        {
            sender?.Send(message);
        }
    }
}