namespace Penguin.Email.Abstractions.Interfaces
{
    /// <summary>
    /// Represents an endpoint capable of sending an email message
    /// </summary>
    public interface ISendMail
    {
        /// <summary>
        /// The function that sends the email message
        /// </summary>
        /// <param name="message">the message to send</param>
        void Send(IEmailMessage message);
    }
}