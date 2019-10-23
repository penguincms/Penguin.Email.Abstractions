using Penguin.Email.Abstractions.Interfaces;

namespace Penguin.Email.Abstractions.Extensions
{
    public static class IQueueMailExtensions
    {
        public static void TryQueue<T>(this IQueueMail sender, IEmailMessage message)
        {
            if (sender != null)
            {
                sender.Queue(message);
            }
        }

        public static void TryReQueue<T>(this IQueueMail sender, IEmailMessage message, string newRecipient = null)
        {
            if (sender != null)
            {
                sender.ReQueue(message, newRecipient);
            }
        }
    }
}