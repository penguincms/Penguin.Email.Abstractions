namespace Penguin.Email.Abstractions.Interfaces
{
    /// <summary>
    /// Represents a class that can queue an email in data persistence for sending later
    /// </summary>
    public interface IQueueMail
    {
        /// <summary>
        /// Queues the email to a database to be sent later
        /// </summary>
        /// <param name="message">The message to queue</param>
        void Queue(IEmailMessage message);

        /// <summary>
        /// Copies the provided message and requeues it with an optional new recipient
        /// </summary>
        /// <param name="message">The message to copy</param>
        /// <param name="newRecipient">If not null, the value will replace the former recipient</param>
        void ReQueue(IEmailMessage message, string newRecipient = null);
    }
}