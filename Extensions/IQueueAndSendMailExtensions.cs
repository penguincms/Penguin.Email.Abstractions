using Penguin.Email.Abstractions.Interfaces;

namespace Penguin.Email.Abstractions.Extensions
{
    public static class IQueueAndSendMailExtensions
    {
        /// <summary>
        /// Sends the email immediately and inserts it into a database in the "Sent" state for record
        /// </summary>
        /// <param name="message">The message to send and queue</param>
        public static void TryQueueAndSend(IQueueAndSendMail sender, IEmailMessage message)
        {
            if (sender != null)
            {
                sender.QueueAndSend(message);
            }
        }

        /// <summary>
        /// Performs the default action between Queue and Send
        /// </summary>
        /// <param name="message">The message to queue or send</param>
        public static void TryQueueOrSend<T>(IQueueAndSendMail sender, T message) where T : IEmailMessage
        {
            if (sender != null)
            {
                sender.QueueOrSend(message);
            }
        }

        /// <summary>
        /// Copies the provided message and requeues it with an optional new recipient, marks it sent, and then immediately sends it
        /// </summary>
        /// <param name="message">The message to copy</param>
        /// <param name="newRecipient">If not null, the value will replace the former recipient</param>
        public static void TryReQueueAndSend<T>(IQueueAndSendMail sender, T message, string newRecipient = null) where T : IEmailMessage
        {
            if (sender != null)
            {
                sender.ReQueueAndSend(message, newRecipient);
            }
        }
    }
}