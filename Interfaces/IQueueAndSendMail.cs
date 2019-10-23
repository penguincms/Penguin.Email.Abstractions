namespace Penguin.Email.Abstractions.Interfaces
{
    /// <summary>
    /// Allows for immediate email sending as well as queuing for later
    /// </summary>
    public interface IQueueAndSendMail : ISendMail, IQueueMail
    {
        /// <summary>
        /// Sends the email immediately and inserts it into a database in the "Sent" state for record
        /// </summary>
        /// <param name="message">The message to send and queue</param>
        void QueueAndSend(IEmailMessage message);

        /// <summary>
        /// Performs the default action between Queue and Send
        /// </summary>
        /// <param name="message">The message to queue or send</param>
        void QueueOrSend(IEmailMessage message);

        /// <summary>
        /// Copies the provided message and requeues it with an optional new recipient, marks it sent, and then immediately sends it
        /// </summary>
        /// <param name="message">The message to copy</param>
        /// <param name="newRecipient">If not null, the value will replace the former recipient</param>
        void ReQueueAndSend(IEmailMessage message, string newRecipient = null);
    }
}